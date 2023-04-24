namespace Bwhere2023
{
    partial class MinimizeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Dock = DockStyle.Fill;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Gray;
            button1.Image = Properties.Resources.logo;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(40, 40);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            button1.MouseDown += button1_MouseDown;
            button1.MouseMove += button1_MouseMove;
            button1.MouseUp += button1_MouseUp;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(40, 40);
            Controls.Add(button1);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(500, 0);
            MaximumSize = new Size(40, 40);
            MinimizeBox = false;
            MinimumSize = new Size(40, 40);
            Name = "Form1";
            StartPosition = FormStartPosition.Manual;
            Text = "Form1";
            TopMost = true;
            Deactivate += MainForm_Deactivate;
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
    }
}