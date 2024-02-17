﻿namespace Attendance_C__XML_Project
{
    partial class StudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            panel3 = new Panel();
            label9 = new Label();
            btnClose = new Button();
            btnShowReport = new Button();
            lblAttended = new Label();
            lblAbsent = new Label();
            lblAbsentNum = new Label();
            lblAttendedNum = new Label();
            btnExportExcel = new Button();
            btnPrintReport = new Button();
            picStudent = new PictureBox();
            panel1 = new Panel();
            lblClass = new Label();
            lblWelcome = new Label();
            lblClassName = new Label();
            button4 = new Button();
            button3 = new Button();
            lblUserName = new Label();
            lblRoleError = new Label();
            panelShow = new Panel();
            panelAttendanceTable = new Panel();
            listBox1 = new ListBox();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picStudent).BeginInit();
            panel1.SuspendLayout();
            panelShow.SuspendLayout();
            panelAttendanceTable.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(73, 178, 202);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(btnClose);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(896, 49);
            panel3.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(3, 9);
            label9.Name = "label9";
            label9.Size = new Size(124, 25);
            label9.TabIndex = 8;
            label9.Text = "Student Form";
            // 
            // btnClose
            // 
            btnClose.BackgroundImage = (Image)resources.GetObject("btnClose.BackgroundImage");
            btnClose.BackgroundImageLayout = ImageLayout.Zoom;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Dock = DockStyle.Right;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(851, 0);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(45, 49);
            btnClose.TabIndex = 0;
            btnClose.UseVisualStyleBackColor = true;
            // 
            // btnShowReport
            // 
            btnShowReport.BackColor = Color.Teal;
            btnShowReport.FlatAppearance.BorderSize = 0;
            btnShowReport.FlatStyle = FlatStyle.Flat;
            btnShowReport.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShowReport.ForeColor = SystemColors.Control;
            btnShowReport.Image = (Image)resources.GetObject("btnShowReport.Image");
            btnShowReport.Location = new Point(356, 22);
            btnShowReport.Margin = new Padding(3, 4, 3, 4);
            btnShowReport.Name = "btnShowReport";
            btnShowReport.Size = new Size(192, 80);
            btnShowReport.TabIndex = 20;
            btnShowReport.Text = "Show Report";
            btnShowReport.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnShowReport.UseVisualStyleBackColor = false;
            btnShowReport.Click += btnShowReport_Click;
            // 
            // lblAttended
            // 
            lblAttended.AutoSize = true;
            lblAttended.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAttended.Location = new Point(523, 16);
            lblAttended.Name = "lblAttended";
            lblAttended.Size = new Size(97, 23);
            lblAttended.TabIndex = 22;
            lblAttended.Text = "Attended";
            // 
            // lblAbsent
            // 
            lblAbsent.AutoSize = true;
            lblAbsent.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAbsent.Location = new Point(523, 50);
            lblAbsent.Name = "lblAbsent";
            lblAbsent.Size = new Size(74, 23);
            lblAbsent.TabIndex = 23;
            lblAbsent.Text = "Absent";
            // 
            // lblAbsentNum
            // 
            lblAbsentNum.AutoSize = true;
            lblAbsentNum.BackColor = Color.Transparent;
            lblAbsentNum.Font = new Font("Segoe UI", 14F);
            lblAbsentNum.ForeColor = Color.Black;
            lblAbsentNum.Location = new Point(642, 50);
            lblAbsentNum.Name = "lblAbsentNum";
            lblAbsentNum.Size = new Size(40, 32);
            lblAbsentNum.TabIndex = 24;
            lblAbsentNum.Text = "00";
            lblAbsentNum.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAttendedNum
            // 
            lblAttendedNum.AutoSize = true;
            lblAttendedNum.BackColor = Color.Transparent;
            lblAttendedNum.Font = new Font("Segoe UI", 14F);
            lblAttendedNum.ForeColor = Color.Black;
            lblAttendedNum.Location = new Point(642, 12);
            lblAttendedNum.Name = "lblAttendedNum";
            lblAttendedNum.Size = new Size(40, 32);
            lblAttendedNum.TabIndex = 25;
            lblAttendedNum.Text = "00";
            lblAttendedNum.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnExportExcel
            // 
            btnExportExcel.BackColor = Color.Teal;
            btnExportExcel.FlatAppearance.BorderSize = 0;
            btnExportExcel.FlatStyle = FlatStyle.Flat;
            btnExportExcel.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportExcel.ForeColor = SystemColors.Control;
            btnExportExcel.Image = (Image)resources.GetObject("btnExportExcel.Image");
            btnExportExcel.ImageAlign = ContentAlignment.MiddleLeft;
            btnExportExcel.Location = new Point(603, 411);
            btnExportExcel.Margin = new Padding(3, 4, 3, 4);
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.Size = new Size(217, 80);
            btnExportExcel.TabIndex = 26;
            btnExportExcel.Text = "Export Excel";
            btnExportExcel.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnExportExcel.UseVisualStyleBackColor = false;
            // 
            // btnPrintReport
            // 
            btnPrintReport.BackColor = Color.Teal;
            btnPrintReport.FlatAppearance.BorderSize = 0;
            btnPrintReport.FlatStyle = FlatStyle.Flat;
            btnPrintReport.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrintReport.ForeColor = SystemColors.Control;
            btnPrintReport.Image = (Image)resources.GetObject("btnPrintReport.Image");
            btnPrintReport.ImageAlign = ContentAlignment.MiddleLeft;
            btnPrintReport.Location = new Point(96, 411);
            btnPrintReport.Margin = new Padding(3, 4, 3, 4);
            btnPrintReport.Name = "btnPrintReport";
            btnPrintReport.Size = new Size(184, 80);
            btnPrintReport.TabIndex = 27;
            btnPrintReport.Text = "Print Pdf";
            btnPrintReport.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnPrintReport.UseVisualStyleBackColor = false;
            // 
            // picStudent
            // 
            picStudent.Image = (Image)resources.GetObject("picStudent.Image");
            picStudent.Location = new Point(12, -5);
            picStudent.Name = "picStudent";
            picStudent.Size = new Size(93, 96);
            picStudent.TabIndex = 28;
            picStudent.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gold;
            panel1.Controls.Add(lblClass);
            panel1.Controls.Add(lblWelcome);
            panel1.Controls.Add(lblClassName);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(lblUserName);
            panel1.Controls.Add(lblRoleError);
            panel1.Controls.Add(picStudent);
            panel1.Controls.Add(lblAttended);
            panel1.Controls.Add(lblAbsent);
            panel1.Controls.Add(lblAttendedNum);
            panel1.Controls.Add(lblAbsentNum);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 49);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(896, 91);
            panel1.TabIndex = 29;
            // 
            // lblClass
            // 
            lblClass.AutoSize = true;
            lblClass.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClass.Location = new Point(111, 49);
            lblClass.Name = "lblClass";
            lblClass.Size = new Size(64, 23);
            lblClass.TabIndex = 34;
            lblClass.Text = "Class:";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(111, 12);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(108, 23);
            lblWelcome.TabIndex = 33;
            lblWelcome.Text = "Welcome: ";
            // 
            // lblClassName
            // 
            lblClassName.AutoSize = true;
            lblClassName.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblClassName.Location = new Point(215, 50);
            lblClassName.Name = "lblClassName";
            lblClassName.Size = new Size(111, 22);
            lblClassName.TabIndex = 32;
            lblClassName.Text = "class name";
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Black;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(854, 48);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(42, 36);
            button4.TabIndex = 31;
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Black;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(856, 8);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(37, 36);
            button3.TabIndex = 30;
            button3.UseVisualStyleBackColor = false;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserName.Location = new Point(215, 12);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(106, 22);
            lblUserName.TabIndex = 29;
            lblUserName.Text = "user name";
            // 
            // lblRoleError
            // 
            lblRoleError.AutoSize = true;
            lblRoleError.ForeColor = Color.IndianRed;
            lblRoleError.Location = new Point(147, 563);
            lblRoleError.MaximumSize = new Size(159, 0);
            lblRoleError.Name = "lblRoleError";
            lblRoleError.Size = new Size(0, 20);
            lblRoleError.TabIndex = 27;
            // 
            // panelShow
            // 
            panelShow.Controls.Add(btnShowReport);
            panelShow.Dock = DockStyle.Top;
            panelShow.Location = new Point(0, 140);
            panelShow.Name = "panelShow";
            panelShow.Size = new Size(896, 125);
            panelShow.TabIndex = 30;
            // 
            // panelAttendanceTable
            // 
            panelAttendanceTable.Controls.Add(listBox1);
            panelAttendanceTable.Controls.Add(btnPrintReport);
            panelAttendanceTable.Controls.Add(btnExportExcel);
            panelAttendanceTable.Dock = DockStyle.Fill;
            panelAttendanceTable.Location = new Point(0, 265);
            panelAttendanceTable.Name = "panelAttendanceTable";
            panelAttendanceTable.Size = new Size(896, 525);
            panelAttendanceTable.TabIndex = 31;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(31, 20);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(839, 384);
            listBox1.TabIndex = 28;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 790);
            Controls.Add(panelAttendanceTable);
            Controls.Add(panelShow);
            Controls.Add(panel1);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StudentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentForm";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picStudent).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelShow.ResumeLayout(false);
            panelAttendanceTable.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Label label9;
        private Button btnClose;
        private Button btnShowReport;
        private Label lblAttended;
        private Label lblAbsent;
        private Label lblAbsentNum;
        private Label lblAttendedNum;
        private Button btnExportExcel;
        private Button btnPrintReport;
        private PictureBox picStudent;
        private Panel panel1;
        private Label lblRoleError;
        private Button button3;
        private Label lblUserName;
        private Button button4;
        private Panel panelShow;
        private Panel panelAttendanceTable;
        private ListBox listBox1;
        private Label lblClassName;
        private Label lblClass;
        private Label lblWelcome;
    }
}