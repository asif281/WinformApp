using BAL.Common;
using BAL.Common.Constants;
using BAL.Services.HttpService;
using BAL.Services.UserService;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
using System.Xml.Linq;

namespace Bwhere2023
{
    public partial class CustomerForm : Form
    {
        private MinimizeForm firstForm;
        private readonly IUserService _userService;
        private bool isDragging = false;
        private bool isMoving = false;
        public string staffId;
        private Point lastMousePosition;
        public string UserName = "Asif";
        private FormLogin formLogin;
        private System.Windows.Forms.Timer timer;

        List<WhereRow> whereData;

        public CustomerForm(MinimizeForm firstForm, IUserService userService)
        {
            InitializeComponent();
            // create and configure the timer
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 120000; // 60 seconds
            timer.Tick += timer1_Tick;

            // start the timer
            timer.Start();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.firstForm = firstForm;
            _userService = userService;
            GetCustomerData();
            formLogin = new FormLogin(_userService);
        }
        public CustomerForm()
        {
        }


        private void button1_Click(object sender, EventArgs e)
        {
            firstForm.UserName = UserName;
            firstForm.Show();
            this.Hide();

        }

        private async void GetCustomerData()
        {

            var response = await _userService.GetCustomerData(ApiUrls.GetCustomerData, Properties.Settings.Default.ApiKey);

            if (response.StatusCode.IsOk())
            {
                this.whereData = response.Body.data;
                foreach (var item in this.whereData)
                {
                    if (item.where_status == "Out")
                    {
                        item.Out = true;
                    }
                    else if (item.where_status == "Meeting")
                    {
                        item.Meeting = true;
                    }
                    else if (item.where_status == "Leave")
                    {
                        item.Leave = true;
                    }
                    else if (item.where_status == "Sick")
                    {
                        item.Sick = true;
                    }
                }
                dataGridView1.DataSource = this.whereData;
                dataGridView1.Refresh();
            }
            else if(response.StatusCode == HttpStatusCode.Unauthorized)
            {
                this.Hide();
                formLogin.Show();
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

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Close the application
                Application.Exit();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //Application.Restart();
            this.Hide();
            formLogin.Show();
            //formLogin.
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            panel3.Visible = false;
            // Assume that we have a ComboBox control named "comboBox1" on our form
            List<string> items = new List<string> { "Out", "Meeting", "Leave", "Sick" }; // this is our list of items

            // We can load the items into the dropdown list like this:
            comboBox1.DataSource = items;
            comboBox1.DisplayMember = "Value"; // assuming that we want to display the string values themselves


            label3.Text = UserName;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GetCustomerData();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0) // check if it's a data row
            {
                var row = dataGridView1.Rows[e.RowIndex];
                var dummy = (WhereRow)row.DataBoundItem;

                if (dummy.Out)
                {
                    row.DefaultCellStyle.BackColor = Color.MediumPurple;
                }
                else if (dummy.Meeting)
                {
                    row.DefaultCellStyle.BackColor = Color.LightBlue;
                }
                else if (dummy.Leave)
                {
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                }
                else if (dummy.Sick)
                {
                    row.DefaultCellStyle.BackColor = Color.Orange;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.Gray;
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                 staffId = row.Cells["id"].Value.ToString();
            }
            panel3.Visible = true;

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                statusUpdate();
            }
        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                statusUpdate();
            }
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                statusUpdate();
            }
        }

        private async Task statusUpdate()
       {
            panel3.Visible = false;

            this.Hide();
            string where = textBox1.Text;
            string returning = dateTimePicker1.Text;
            string status = comboBox1.Text;
            // Call your function here

            UserAwayInfo userAwayInfo = new UserAwayInfo()
            {
                where_current_location = where,
                where_returning_to_work = returning,
                where_status = status
            };

            string userAwayUrl = Properties.Settings.Default.ApiUrl + ApiUrls.GetUserAway + staffId;
            
            var response = await _userService.SetUserAway(userAwayUrl, Properties.Settings.Default.ApiKey, userAwayInfo);

            MessageBox.Show("update API");
            panel3.Visible = false;
        }
    }
}