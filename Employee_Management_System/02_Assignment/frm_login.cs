using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Management_System
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=EMPLOYEE_MANAGEMENT_SYSTEM_DATABASE;Integrated Security=True");

        void Con_Open()
        {
            if (Con.State != ConnectionState.Open)
            {
                Con.Open();
            }
        }

        void Con_Close()
        {
            if ( Con.State !=ConnectionState.Closed)
            {
                Con.Close();
            }
        }

        private void frm_login_Load(object sender, EventArgs e)
        {
            tb_username.Focus();
        }

        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsLetter(e.KeyChar) || (e.KeyChar == (char) Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            Con_Open();

            int Cnt = 0;

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;
            Cmd.CommandText = "Select count (*) from Login_Details Where Username = @Uname And Password = @pwd";

            Cmd.Parameters.Add("Uname", SqlDbType.NVarChar).Value = tb_username.Text;
            Cmd.Parameters.Add("pwd", SqlDbType.NVarChar).Value = tb_password.Text;

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            if(Cnt > 0)
            {
                MessageBox.Show("Login sucessful","Welcome",MessageBoxButtons.OK,MessageBoxIcon.Information);

                Common_Content.Log_UName = "Welcome " + tb_username.Text;

                frm_Add_New_Employee obj = new frm_Add_New_Employee();
                obj.Show();
                this.Hide();
            }
            else
            {
                lbl_Note.Text = "Incorrect username or password !!!";
                lbl_Note.ForeColor = Color.Red;
            }
            tb_username.Clear();
            tb_password.Clear();

            
        }
    }
}
