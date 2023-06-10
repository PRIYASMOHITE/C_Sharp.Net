using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            if (tb_username.Text == "Admin" && tb_password.Text == "p123")
            {
                MessageBox.Show("Login sucessful","Welcome",MessageBoxButtons.OK,MessageBoxIcon.Information);
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
