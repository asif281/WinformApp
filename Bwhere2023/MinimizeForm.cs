using BAL.Common.Responses;
using BAL.Services.HttpService;
using BAL.Services.UserService;
using System.Runtime.InteropServices;

namespace Bwhere2023
{

    public partial class MinimizeForm : Form
    {
        IUserService _userService;
        private CustomerForm secondForm;

        private bool isDragging = false;
        private bool isMoving = false;
        private Point lastMousePosition;
        public string UserName = "Asif";

        [DllImport("user32.dll")]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int x, int y, int cx, int cy, uint uFlags);

        private const uint SWP_NOMOVE = 0x0002;
        private const uint SWP_NOSIZE = 0x0001;
        private const uint SWP_NOZORDER = 0x0004;
        private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);


        // Call this method to make the form topmost
        private void MakeTopMost()
        {
            SetWindowPos(this.Handle, HWND_TOPMOST, 0, 0, 0, 0, SWP_NOMOVE | SWP_NOSIZE | SWP_NOZORDER);
        }

        public MinimizeForm(IUserService userService)
        {
            _userService = userService;
            InitializeComponent();
            secondForm = new CustomerForm(this, _userService);
            ShowInTaskbar = false; // Set this to true to prevent the form from showing in the system tray
            TopMost = true;

            this.Left = Properties.Settings.Default.FormStartLocationX;
            this.Top = Properties.Settings.Default.FormStartLocationY;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isMoving == false)
            {
                secondForm.UserName = UserName;
                secondForm.Show();
                this.Hide();
            }
        }

        private void MainForm_Deactivate(object sender, EventArgs e)
        {
            TopMost = true;
        }


        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            lastMousePosition = MousePosition;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                isMoving = true;
                Point delta = new Point(MousePosition.X - lastMousePosition.X, MousePosition.Y - lastMousePosition.Y);
                this.Location = new Point(this.Location.X + delta.X, this.Location.Y + delta.Y);
                lastMousePosition = MousePosition;

            }
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
            MoveFormToNearestEdge();
            isMoving = false;

            Properties.Settings.Default.FormStartLocationX = this.Left;
            Properties.Settings.Default.FormStartLocationY = this.Top;
            Properties.Settings.Default.Save();
        }

        private void MoveFormToNearestEdge()
        {
            int screenWidth = Screen.FromControl(this).WorkingArea.Width;
            int screenHeight = Screen.FromControl(this).WorkingArea.Height;
            int formX = Location.X;
            int formY = Location.Y;

            // Calculate the distances to each edge
            int left = formX;
            int right = screenWidth - formX - Width;
            int top = formY;
            int bottom = screenHeight - formY - Height;

            // Determine the nearest edge
            int nearestEdge = Math.Min(Math.Min(left, right), Math.Min(top, bottom));

            // Move the form to the nearest edge
            if (nearestEdge == left)
            {
                Location = new Point(0, formY);
            }
            else if (nearestEdge == right)
            {
                Location = new Point(screenWidth - Width, formY);
            }
            else if (nearestEdge == top)
            {
                Location = new Point(formX, 0);
            }
            else if (nearestEdge == bottom)
            {
                Location = new Point(formX, screenHeight - Height);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MakeTopMost();
        }
    }
}