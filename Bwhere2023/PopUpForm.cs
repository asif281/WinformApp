using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bwhere2023
{
    public partial class PopUpForm : Form
    {
        public PopUpForm()
        {
            InitializeComponent();
        }

        private void PopUpForm_Load(object sender, EventArgs e)
        {
            // Assume that we have a ComboBox control named "comboBox1" on our form
            List<string> items = new List<string> { "Out", "Meeting", "Leave", "Sick" }; // this is our list of items

            // We can load the items into the dropdown list like this:
            comboBox1.DataSource = items;
            comboBox1.DisplayMember = "Value"; // assuming that we want to display the string values themselves

        }

        private void PopUpForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Call your function here
                this.Hide();
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Call your function here
                this.Hide();
            }
        }
    }
}
