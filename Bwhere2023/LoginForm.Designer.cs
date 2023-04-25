namespace Bwhere2023
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            button1 = new Button();
            RememberEmail = new CheckBox();
            validationLabel = new Label();
            Info = new Label();
            Login = new Button();
            panel3 = new Panel();
            textBoxPassword = new TextBox();
            panel2 = new Panel();
            textBoxEmail = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(RememberEmail);
            panel1.Controls.Add(validationLabel);
            panel1.Controls.Add(Info);
            panel1.Controls.Add(Login);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(450, 227);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(317, 146);
            button1.Name = "button1";
            button1.Size = new Size(111, 33);
            button1.TabIndex = 8;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // RememberEmail
            // 
            RememberEmail.AutoSize = true;
            RememberEmail.BackColor = Color.RoyalBlue;
            RememberEmail.ForeColor = Color.White;
            RememberEmail.Location = new Point(186, 60);
            RememberEmail.Name = "RememberEmail";
            RememberEmail.Size = new Size(116, 19);
            RememberEmail.TabIndex = 7;
            RememberEmail.Text = "Remember Email";
            RememberEmail.TextImageRelation = TextImageRelation.TextBeforeImage;
            RememberEmail.UseVisualStyleBackColor = false;
            // 
            // validationLabel
            // 
            validationLabel.BackColor = Color.Snow;
            validationLabel.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point);
            validationLabel.ForeColor = Color.Red;
            validationLabel.Location = new Point(183, 115);
            validationLabel.Name = "validationLabel";
            validationLabel.Size = new Size(257, 28);
            validationLabel.TabIndex = 6;
            validationLabel.Text = "username or password not valid.";
            validationLabel.UseMnemonic = false;
            validationLabel.Visible = false;
            // 
            // Info
            // 
            Info.AutoSize = true;
            Info.BackColor = Color.AliceBlue;
            Info.FlatStyle = FlatStyle.Popup;
            Info.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Info.ForeColor = Color.SeaGreen;
            Info.Location = new Point(183, 114);
            Info.MinimumSize = new Size(190, 5);
            Info.Name = "Info";
            Info.Size = new Size(190, 14);
            Info.TabIndex = 5;
            Info.Text = "Logging in...";
            Info.Visible = false;
            // 
            // Login
            // 
            Login.BackColor = Color.White;
            Login.FlatAppearance.BorderSize = 0;
            Login.FlatStyle = FlatStyle.Flat;
            Login.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Login.ForeColor = SystemColors.ActiveCaptionText;
            Login.Location = new Point(186, 146);
            Login.Name = "Login";
            Login.Size = new Size(111, 33);
            Login.TabIndex = 3;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = false;
            Login.Click += Login_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(textBoxPassword);
            panel3.Location = new Point(183, 80);
            panel3.Name = "panel3";
            panel3.Size = new Size(257, 31);
            panel3.TabIndex = 4;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BorderStyle = BorderStyle.None;
            textBoxPassword.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.Location = new Point(0, 8);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.PlaceholderText = "password";
            textBoxPassword.Size = new Size(245, 17);
            textBoxPassword.TabIndex = 2;
            textBoxPassword.UseSystemPasswordChar = true;
            textBoxPassword.KeyDown += KeyDown;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(textBoxEmail);
            panel2.Location = new Point(183, 24);
            panel2.Name = "panel2";
            panel2.Size = new Size(257, 32);
            panel2.TabIndex = 3;
            // 
            // textBoxEmail
            // 
            textBoxEmail.BorderStyle = BorderStyle.None;
            textBoxEmail.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEmail.Location = new Point(3, 3);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.PlaceholderText = "email address";
            textBoxEmail.Size = new Size(245, 17);
            textBoxEmail.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(28, 60);
            label1.Name = "label1";
            label1.Size = new Size(96, 25);
            label1.TabIndex = 1;
            label1.Text = "B-Where";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Padding = new Padding(5);
            pictureBox1.Size = new Size(163, 210);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 210);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLogin";
            Text = "Form3";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private TextBox textBoxEmail;
        private Label label1;
        private Panel panel3;
        private TextBox textBoxPassword;
        private Button Login;
        private Label Info;
        private Label validationLabel;
        private CheckBox RememberEmail;
        private Button button1;
    }
}