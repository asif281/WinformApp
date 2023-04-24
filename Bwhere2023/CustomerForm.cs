using BAL.Common;
using BAL.Common.Constants;
using BAL.Services.HttpService;
using BAL.Services.UserService;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bwhere2023
{
    public partial class CustomerForm : Form
    {
        private MinimizeForm firstForm;
        private readonly IUserService _userService;
        private bool isDragging = false;
        private bool isMoving = false;
        private Point lastMousePosition;

        List<WhereRow> whereData;

        public CustomerForm(MinimizeForm firstForm, IUserService userService)
        {
            InitializeComponent();
            this.firstForm = firstForm;
            _userService = userService;
            GetCustomerData();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            firstForm.Show();
            this.Hide();

        }

        private async void GetCustomerData()
        {

            var response = await _userService.GetCustomerData(ApiUrls.GetCustomerData, Properties.Settings.Default.ApiKey);

            if (response.StatusCode.IsOk())
            {
                this.whereData = response.Body.data;
                dataGridView1.DataSource = this.whereData;
                dataGridView1.Refresh();
            }
        
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            int arcWidth = 10;
            int arcHeight = 10;
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
            path.AddArc(rect.X, rect.Y, arcWidth, arcHeight, 180, 90);
            path.AddArc(rect.X + rect.Width - arcWidth, rect.Y, arcWidth, arcHeight, 270, 90);
            path.AddArc(rect.X + rect.Width - arcWidth, rect.Y + rect.Height - arcHeight, arcWidth, arcHeight, 0, 90);
            path.AddArc(rect.X, rect.Y + rect.Height - arcHeight, arcWidth, arcHeight, 90, 90);
            path.CloseFigure();
            this.Region = new Region(path);

            base.OnPaint(e);
        }



        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            lastMousePosition = MousePosition;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                isMoving = true;
                Point delta = new Point(MousePosition.X - lastMousePosition.X, MousePosition.Y - lastMousePosition.Y);
                this.Location = new Point(this.Location.X + delta.X, this.Location.Y + delta.Y);
                lastMousePosition = MousePosition;

            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
            isMoving = false;

            //Properties.Settings.Default.FormStartLocationX = this.Left;
            //Properties.Settings.Default.FormStartLocationY = this.Top;
            //Properties.Settings.Default.Save();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}