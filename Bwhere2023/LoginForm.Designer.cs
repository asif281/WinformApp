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
            this.panel1 = new System.Windows.Forms.Panel();
            this.RememberEmail = new System.Windows.Forms.CheckBox();
            this.validationLabel = new System.Windows.Forms.Label();
            this.Info = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.RememberEmail);
            this.panel1.Controls.Add(this.validationLabel);
            this.panel1.Controls.Add(this.Info);
            this.panel1.Controls.Add(this.Login);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 227);
            this.panel1.TabIndex = 0;
            // 
            // RememberEmail
            // 
            this.RememberEmail.AutoSize = true;
            this.RememberEmail.BackColor = System.Drawing.Color.RoyalBlue;
            this.RememberEmail.ForeColor = System.Drawing.Color.White;
            this.RememberEmail.Location = new System.Drawing.Point(186, 60);
            this.RememberEmail.Name = "RememberEmail";
            this.RememberEmail.Size = new System.Drawing.Size(116, 19);
            this.RememberEmail.TabIndex = 7;
            this.RememberEmail.Text = "Remember Email";
            this.RememberEmail.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.RememberEmail.UseVisualStyleBackColor = false;
            // 
            // validationLabel
            // 
            this.validationLabel.BackColor = System.Drawing.Color.Snow;
            this.validationLabel.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.validationLabel.ForeColor = System.Drawing.Color.Red;
            this.validationLabel.Location = new System.Drawing.Point(183, 115);
            this.validationLabel.Name = "validationLabel";
            this.validationLabel.Size = new System.Drawing.Size(257, 28);
            this.validationLabel.TabIndex = 6;
            this.validationLabel.Text = "username or password not valid.";
            this.validationLabel.UseMnemonic = false;
            this.validationLabel.Visible = false;
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.BackColor = System.Drawing.Color.AliceBlue;
            this.Info.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Info.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Info.ForeColor = System.Drawing.Color.SeaGreen;
            this.Info.Location = new System.Drawing.Point(183, 114);
            this.Info.MinimumSize = new System.Drawing.Size(190, 5);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(190, 14);
            this.Info.TabIndex = 5;
            this.Info.Text = "Logging in...";
            this.Info.Visible = false;
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.White;
            this.Login.FlatAppearance.BorderSize = 0;
            this.Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Login.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Login.Location = new System.Drawing.Point(246, 146);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(111, 33);
            this.Login.TabIndex = 3;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.textBoxPassword);
            this.panel3.Location = new System.Drawing.Point(183, 80);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(257, 31);
            this.panel3.TabIndex = 4;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPassword.Location = new System.Drawing.Point(0, 8);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.PlaceholderText = "password";
            this.textBoxPassword.Size = new System.Drawing.Size(245, 17);
            this.textBoxPassword.TabIndex = 2;
            this.textBoxPassword.UseSystemPasswordChar = true;
            this.textBoxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.textBoxEmail);
            this.panel2.Location = new System.Drawing.Point(183, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(257, 32);
            this.panel2.TabIndex = 3;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxEmail.Location = new System.Drawing.Point(3, 3);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.PlaceholderText = "email address";
            this.textBoxEmail.Size = new System.Drawing.Size(245, 17);
            this.textBoxEmail.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(28, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "B-Where";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::Bwhere2023.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Size = new System.Drawing.Size(163, 210);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 210);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.Text = "Form3";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}