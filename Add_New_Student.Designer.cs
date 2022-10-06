namespace SGM_Application
{
    partial class frm_Add_New_Student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Add_New_Student));
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_RollN0 = new System.Windows.Forms.Label();
            this.lbl_DOB = new System.Windows.Forms.Label();
            this.lbl_MobileNo = new System.Windows.Forms.Label();
            this.lbl_Course = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_Rollno = new System.Windows.Forms.TextBox();
            this.tb_MobileNo = new System.Windows.Forms.TextBox();
            this.dtp_DOB = new System.Windows.Forms.DateTimePicker();
            this.cmb_Course = new System.Windows.Forms.ComboBox();
            this.lbl_Add_New_Student = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_View_Student_Details = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.BackColor = System.Drawing.Color.Violet;
            this.lbl_Name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Name.Font = new System.Drawing.Font("Rockwell Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_Name.Location = new System.Drawing.Point(169, 153);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(76, 41);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "Name";
            // 
            // lbl_RollN0
            // 
            this.lbl_RollN0.AutoSize = true;
            this.lbl_RollN0.BackColor = System.Drawing.Color.Violet;
            this.lbl_RollN0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_RollN0.Font = new System.Drawing.Font("Rockwell Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RollN0.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_RollN0.Location = new System.Drawing.Point(154, 231);
            this.lbl_RollN0.Name = "lbl_RollN0";
            this.lbl_RollN0.Size = new System.Drawing.Size(92, 41);
            this.lbl_RollN0.TabIndex = 1;
            this.lbl_RollN0.Text = "RollNo.";
            // 
            // lbl_DOB
            // 
            this.lbl_DOB.AutoSize = true;
            this.lbl_DOB.BackColor = System.Drawing.Color.Violet;
            this.lbl_DOB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_DOB.Font = new System.Drawing.Font("Rockwell Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DOB.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_DOB.Location = new System.Drawing.Point(173, 310);
            this.lbl_DOB.Name = "lbl_DOB";
            this.lbl_DOB.Size = new System.Drawing.Size(73, 41);
            this.lbl_DOB.TabIndex = 2;
            this.lbl_DOB.Text = "D.O.B";
            // 
            // lbl_MobileNo
            // 
            this.lbl_MobileNo.AutoSize = true;
            this.lbl_MobileNo.BackColor = System.Drawing.Color.Violet;
            this.lbl_MobileNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_MobileNo.Font = new System.Drawing.Font("Rockwell Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MobileNo.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_MobileNo.Location = new System.Drawing.Point(124, 387);
            this.lbl_MobileNo.Name = "lbl_MobileNo";
            this.lbl_MobileNo.Size = new System.Drawing.Size(121, 41);
            this.lbl_MobileNo.TabIndex = 3;
            this.lbl_MobileNo.Text = "MobileNo.";
            // 
            // lbl_Course
            // 
            this.lbl_Course.AutoSize = true;
            this.lbl_Course.BackColor = System.Drawing.Color.Violet;
            this.lbl_Course.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Course.Font = new System.Drawing.Font("Rockwell Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Course.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_Course.Location = new System.Drawing.Point(165, 473);
            this.lbl_Course.Name = "lbl_Course";
            this.lbl_Course.Size = new System.Drawing.Size(86, 41);
            this.lbl_Course.TabIndex = 4;
            this.lbl_Course.Text = "Course";
            // 
            // tb_Name
            // 
            this.tb_Name.BackColor = System.Drawing.Color.AliceBlue;
            this.tb_Name.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(416, 153);
            this.tb_Name.MaxLength = 50;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(249, 46);
            this.tb_Name.TabIndex = 1;
            this.tb_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Name);
            // 
            // tb_Rollno
            // 
            this.tb_Rollno.BackColor = System.Drawing.Color.AliceBlue;
            this.tb_Rollno.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Rollno.Location = new System.Drawing.Point(416, 231);
            this.tb_Rollno.MaxLength = 5;
            this.tb_Rollno.Name = "tb_Rollno";
            this.tb_Rollno.Size = new System.Drawing.Size(249, 46);
            this.tb_Rollno.TabIndex = 2;
            this.tb_Rollno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // tb_MobileNo
            // 
            this.tb_MobileNo.BackColor = System.Drawing.Color.AliceBlue;
            this.tb_MobileNo.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MobileNo.Location = new System.Drawing.Point(416, 382);
            this.tb_MobileNo.MaxLength = 10;
            this.tb_MobileNo.Name = "tb_MobileNo";
            this.tb_MobileNo.Size = new System.Drawing.Size(249, 46);
            this.tb_MobileNo.TabIndex = 4;
            this.tb_MobileNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // dtp_DOB
            // 
            this.dtp_DOB.CalendarForeColor = System.Drawing.SystemColors.Control;
            this.dtp_DOB.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.dtp_DOB.Font = new System.Drawing.Font("Rockwell Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_DOB.Location = new System.Drawing.Point(416, 310);
            this.dtp_DOB.MaxDate = new System.DateTime(2002, 12, 31, 0, 0, 0, 0);
            this.dtp_DOB.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.dtp_DOB.Name = "dtp_DOB";
            this.dtp_DOB.Size = new System.Drawing.Size(249, 46);
            this.dtp_DOB.TabIndex = 3;
            this.dtp_DOB.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // cmb_Course
            // 
            this.cmb_Course.Font = new System.Drawing.Font("Rockwell Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Course.FormattingEnabled = true;
            this.cmb_Course.Items.AddRange(new object[] {
            "Bsc Cs",
            "Bcs",
            "Bca",
            "Mcs",
            "Mca",
            "Bsc"});
            this.cmb_Course.Location = new System.Drawing.Point(416, 473);
            this.cmb_Course.MaxLength = 10;
            this.cmb_Course.Name = "cmb_Course";
            this.cmb_Course.Size = new System.Drawing.Size(249, 47);
            this.cmb_Course.TabIndex = 5;
            // 
            // lbl_Add_New_Student
            // 
            this.lbl_Add_New_Student.AutoSize = true;
            this.lbl_Add_New_Student.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.lbl_Add_New_Student.Font = new System.Drawing.Font("Rockwell Condensed", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_New_Student.ForeColor = System.Drawing.Color.FloralWhite;
            this.lbl_Add_New_Student.Location = new System.Drawing.Point(229, 46);
            this.lbl_Add_New_Student.Name = "lbl_Add_New_Student";
            this.lbl_Add_New_Student.Size = new System.Drawing.Size(419, 80);
            this.lbl_Add_New_Student.TabIndex = 11;
            this.lbl_Add_New_Student.Text = "Add New Student";
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Cyan;
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.Font = new System.Drawing.Font("Rockwell Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_Save.Location = new System.Drawing.Point(119, 587);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(132, 49);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_View_Student_Details
            // 
            this.btn_View_Student_Details.BackColor = System.Drawing.Color.Cyan;
            this.btn_View_Student_Details.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_View_Student_Details.Font = new System.Drawing.Font("Rockwell Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_View_Student_Details.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_View_Student_Details.Location = new System.Drawing.Point(416, 581);
            this.btn_View_Student_Details.Name = "btn_View_Student_Details";
            this.btn_View_Student_Details.Size = new System.Drawing.Size(429, 55);
            this.btn_View_Student_Details.TabIndex = 7;
            this.btn_View_Student_Details.Text = "View Student Details";
            this.btn_View_Student_Details.UseVisualStyleBackColor = false;
            this.btn_View_Student_Details.Click += new System.EventHandler(this.btn_View_Student_Details_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.Crimson;
            this.btn_Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Logout.Font = new System.Drawing.Font("Rockwell Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Logout.Location = new System.Drawing.Point(765, 12);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(105, 52);
            this.btn_Logout.TabIndex = 14;
            this.btn_Logout.Text = "LogOut";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // frm_Add_New_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 703);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.btn_View_Student_Details);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.lbl_Add_New_Student);
            this.Controls.Add(this.cmb_Course);
            this.Controls.Add(this.dtp_DOB);
            this.Controls.Add(this.tb_MobileNo);
            this.Controls.Add(this.tb_Rollno);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.lbl_Course);
            this.Controls.Add(this.lbl_MobileNo);
            this.Controls.Add(this.lbl_DOB);
            this.Controls.Add(this.lbl_RollN0);
            this.Controls.Add(this.lbl_Name);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Add_New_Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_New_Student";
            
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Name);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_RollN0;
        private System.Windows.Forms.Label lbl_DOB;
        private System.Windows.Forms.Label lbl_MobileNo;
        private System.Windows.Forms.Label lbl_Course;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_Rollno;
        private System.Windows.Forms.TextBox tb_MobileNo;
        private System.Windows.Forms.DateTimePicker dtp_DOB;
        private System.Windows.Forms.ComboBox cmb_Course;
        private System.Windows.Forms.Label lbl_Add_New_Student;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_View_Student_Details;
        private System.Windows.Forms.Button btn_Logout;
    }
}