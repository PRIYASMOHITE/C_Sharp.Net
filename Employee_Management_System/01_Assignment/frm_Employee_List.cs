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
    public partial class frm_Employee_List : Form
    {
        public frm_Employee_List()
        {
            InitializeComponent();
        }

        private void btn_Add_New_Employee_Click(object sender, EventArgs e)
        {
           frm_Add_New_Employee obj = new frm_Add_New_Employee();
            obj.Show();
            this.Hide();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            frm_login obj = new frm_login();
            obj.Show();
            this.Hide();
        }

        private void frm_Employee_List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eMPLOYEE_MANAGEMENT_SYSTEM_DATABASEDataSet.Employee_Details' table. You can move, or remove it, as needed.
            this.employee_DetailsTableAdapter.Fill(this.eMPLOYEE_MANAGEMENT_SYSTEM_DATABASEDataSet.Employee_Details);

        }
    }
}
