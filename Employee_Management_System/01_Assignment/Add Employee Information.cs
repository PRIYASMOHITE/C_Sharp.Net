using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Management_System
{
    public partial class frm_Add_New_Employee : Form
    {
        public frm_Add_New_Employee()
        {
            InitializeComponent();
        }

        void Clear_Controls()
        {
            tb_id.Clear();
            tb_name.Clear();
            tb_Mob_No.Clear();
            dtp_dob.Text = "31-12-2009";
            cmb_Des.SelectedIndex = -1;
            tb_id.Focus();
        }

        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=EMPLOYEE_MANAGEMENT_SYSTEM_DATABASE;Integrated Security=True");

        void Con_Open()
        {
            if (Con.State != ConnectionState.Open)
            {
                Con.Open();
            }
        }

        void Con_close()
        {
            if (Con.State != ConnectionState.Closed)
            {
                Con.Close();
            }

        }

        private void frm_Add_New_Employee_Load(object sender, EventArgs e)
        {
            tb_id.Focus();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_emp_list_Click(object sender, EventArgs e)
        {
            frm_Employee_List obj = new frm_Employee_List();
            obj.Show();
            this.Hide();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            frm_login obj = new frm_login();
            obj.Show();
            this.Hide();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            if(tb_id.Text != "" && tb_name.Text != "" && tb_Mob_No.Text != "" && cmb_Des.Text != "") 
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Con;
                cmd.CommandText = "Insert into Employee_Details values (@Id,@Nm, @MobNo, @Dob, @Des)";
                cmd.Parameters.Add("Id", SqlDbType.Int).Value = tb_id.Text;
                cmd.Parameters.Add("Nm", SqlDbType.VarChar).Value = tb_name.Text;
                cmd.Parameters.Add("MobNo", SqlDbType.Decimal).Value = tb_Mob_No.Text;
                cmd.Parameters.Add("Dob", SqlDbType.Date).Value = dtp_dob.Value.Date;
                cmd.Parameters.Add("Des", SqlDbType.NVarChar).Value = cmb_Des.Text;

                cmd.ExecuteNonQuery();

                MessageBox.Show("Record Inserted sucessfully!!!", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); 
                  
                Clear_Controls();
            }
            else
            {
                MessageBox.Show("1st Fill All Fields", "Incomplete Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Con_close();
        }
    }
}
