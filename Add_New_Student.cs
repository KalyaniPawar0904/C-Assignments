using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SGM_Application
{
    public partial class frm_Add_New_Student : Form
    {
        public frm_Add_New_Student()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=student_DB;Integrated Security=True");
        void Con_Open()
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
        }

        void Con_Close()
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();
            }
        }

       
        private void Only_Name(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || (e.KeyChar == (Char)Keys.Back) || (e.KeyChar == (Char)Keys.Space)))
            {
                e.Handled = true;
            }

        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (Char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        void Clear_Controls()
        {
            tb_Name.Text = "";
            tb_Rollno.Clear();
            tb_MobileNo.Clear();
            cmb_Course.SelectedIndex = -1;
            dtp_DOB.Text = "31-12-2002";
        }
            


        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Rollno.Text != " " && tb_MobileNo.Text != " " && tb_MobileNo.TextLength == 10 && cmb_Course.Text != " ")
            {
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con;
                Cmd.CommandText = "Insert into Student_Details(RollNo, Name, DOB, MobileNo, Course) Values (@RNo,@Nm,@DOB,@MNo,@Course)";

                Cmd.Parameters.Add("RNo", SqlDbType.Int).Value = tb_Rollno.Text;
                Cmd.Parameters.Add("Nm", SqlDbType.VarChar).Value = tb_Name.Text;
                Cmd.Parameters.Add("DOB", SqlDbType.Date).Value = dtp_DOB.Value.Date;
                Cmd.Parameters.Add("MNo", SqlDbType.Decimal).Value = tb_MobileNo.Text;
                Cmd.Parameters.Add("Course", SqlDbType.NVarChar).Value = cmb_Course.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Data Inserted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                tb_Rollno.Clear();
                tb_Name.Clear();
                tb_MobileNo.Clear();
                dtp_DOB.Text = "31/12/2002";
                cmb_Course.SelectedText = "-1";
            }
            else
            {
                MessageBox.Show("Please Fill Out All The Fields", "Failed", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            }

            Con_Close();
            
        }

        private void btn_View_Student_Details_Click(object sender, EventArgs e)
        {
            frm_View_Student_Details Obj = new frm_View_Student_Details();
            Obj.Show();
            this.Hide();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            frm_login obj = new frm_login();
            obj.Show();
            this.Hide();
        }


    }
        
    }

