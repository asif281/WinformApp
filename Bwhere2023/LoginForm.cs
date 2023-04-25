using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL.Common.Constants;
using BAL.Services.HttpService;
using BAL.Services.UserService;
using Microsoft.VisualBasic.Logging;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Bwhere2023
{
    public partial class FormLogin : Form
    {
        private readonly IUserService _userService = null;
        CustomerForm customerForm = new CustomerForm();
        public FormLogin(IEasyHttpClient easyHttpClient, IUserService userService)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            _userService = userService;
        }
        public FormLogin()
        {
            InitializeComponent();
        }

        private void focusOnEmail(object sender, EventArgs e)
        {
            textBoxEmail.Focus();
        }

        private void focusOnPassword(object sender, EventArgs e)
        {
            textBoxPassword.Focus();
        }

        private void OnValidating(string message, bool error = true)
        {
            validationLabel.ForeColor = !error ? Color.ForestGreen : Color.Red;
            validationLabel.Text = message;
            validationLabel.Visible = true;
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(textBoxEmail.Text) && string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                validationLabel.Visible = true;
                Login.Enabled = true;
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxEmail.Text))
            {
                OnValidating("* Email is required");
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                OnValidating("* Password is required");
                return false;
            }

            return true;
        }

        private bool AuthUserInputs()
        {
            if (!ValidateInputs()) return false;

            return true;
        }

        private async void Login_Click(object sender, EventArgs e)
        {
            try
            {
                if (!AuthUserInputs())
                {
                    return;
                }
                else
                {
                    await LoggingInProcess();

                    string url = Properties.Settings.Default.ApiUrl + ApiUrls.GetAppToken;



                    var response = await _userService.UserLogin(url, textBoxEmail.Text, textBoxPassword.Text, "Bwhere windows");

                    if (response.StatusCode.IsOk())
                    {
                        Properties.Settings.Default.ApiKey = response.Body.Data;
                        Properties.Settings.Default.Save();

                        this.GetUser();
                    }
                }

            }
            catch (Exception ex)
            {
                await LoggingFailed();
                OnValidating($"Please Entered Valid Credentials. Error: {ex.Message}");
            }
        }

        private async void GetUser()
        {
            await GettingUserDataInProcess();

            var profileUrl = Properties.Settings.Default.ApiUrl + ApiUrls.GetUser;

            var response = await _userService.GetUser(profileUrl, Properties.Settings.Default.ApiKey);

            if (response.StatusCode.IsOk())
            {
                if (RememberEmail.Checked)
                {
                    Properties.Settings.Default.LoggedInUserId = response.Body.Id;
                    Properties.Settings.Default.LoggedInUserName = response.Body.Name;
                    Properties.Settings.Default.LoggedInUserEmail = response.Body.Email;
                    Properties.Settings.Default.Save();

                }

                var mainForm = new MinimizeForm(_userService);
                mainForm.UserName = response.Body.Name;
                mainForm.Show();
                this.Hide();
            }

        }

        private async Task LoggingInProcess()
        {
            Login.Enabled = false;
            Info.Visible = true;
            validationLabel.Visible = false;
        }

        private async Task GettingUserDataInProcess()
        {
            Login.Enabled = false;
            Info.Visible = true;
            Info.Text = "Getting Customers Data....";
            validationLabel.Visible = false;
        }

        private async Task LoggingFailed()
        {
            Login.Enabled = true;
            Info.Visible = true;
            validationLabel.Visible = false;
        }

        private void KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Trigger login action
                Login_Click(sender, e);

            }
            else
            {
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Close the application
                Application.Exit();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}