namespace Bwhere2023
{
    partial class CustomerForm
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            button1 = new Button();
            panel1 = new Panel();
            label1 = new Label();
            toolTip1 = new ToolTip(components);
            dataGridView1 = new DataGridView();
            Staff = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Lucida Sans Unicode", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(757, 4);
            button1.Name = "button1";
            button1.Size = new Size(31, 33);
            button1.TabIndex = 1;
            button1.Text = "-";
            toolTip1.SetToolTip(button1, "Minimise");
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 41);
            panel1.TabIndex = 2;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(10, 9);
            label1.Name = "label1";
            label1.Size = new Size(96, 25);
            label1.TabIndex = 0;
            label1.Text = "B-Where";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Staff, Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.GridColor = SystemColors.InactiveBorder;
            dataGridView1.Location = new Point(0, 41);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.LightGray;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(800, 376);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Staff
            // 
            Staff.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Staff.HeaderText = "Staff";
            Staff.Name = "Staff";
            Staff.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.HeaderText = "Ext";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 50;
            // 
            // Column2
            // 
            Column2.HeaderText = "Status";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 130;
            // 
            // Column3
            // 
            Column3.HeaderText = "Expected";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 130;
            // 
            // Column4
            // 
            Column4.HeaderText = "Returning";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 130;
            // 
            // Column5
            // 
            Column5.HeaderText = "Where";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 150;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 414);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 36);
            panel2.TabIndex = 4;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            Text = "Form2";
            TopMost = true;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private ToolTip toolTip1;
        private Panel panel1;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Staff;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Panel panel2;
    }
}