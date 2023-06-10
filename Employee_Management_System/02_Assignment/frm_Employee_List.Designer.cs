namespace Employee_Management_System
{
    partial class frm_Employee_List
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Employee_List));
            this.lbl_Employee_Detail_List = new System.Windows.Forms.Label();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_Add_New_Employee = new System.Windows.Forms.Button();
            this.dgv_Employee_Detail_List = new System.Windows.Forms.DataGridView();
            this.empIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eMPLOYEE_MANAGEMENT_SYSTEM_DATABASEDataSet = new Employee_Management_System.EMPLOYEE_MANAGEMENT_SYSTEM_DATABASEDataSet();
            this.empMgtSystemDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emp_Mgt_System_DBDataSet = new Employee_Management_System.Emp_Mgt_System_DBDataSet();
            this.empMgtSystemDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emp_Mgt_System_DB = new Employee_Management_System.Emp_Mgt_System_DB();
            this.lbl_Uname = new System.Windows.Forms.Label();
            this.employee_DetailsTableAdapter = new Employee_Management_System.EMPLOYEE_MANAGEMENT_SYSTEM_DATABASEDataSetTableAdapters.Employee_DetailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Employee_Detail_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEE_MANAGEMENT_SYSTEM_DATABASEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empMgtSystemDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emp_Mgt_System_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empMgtSystemDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emp_Mgt_System_DB)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Employee_Detail_List
            // 
            this.lbl_Employee_Detail_List.AutoSize = true;
            this.lbl_Employee_Detail_List.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbl_Employee_Detail_List.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Employee_Detail_List.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Employee_Detail_List.Location = new System.Drawing.Point(214, 34);
            this.lbl_Employee_Detail_List.Name = "lbl_Employee_Detail_List";
            this.lbl_Employee_Detail_List.Size = new System.Drawing.Size(342, 38);
            this.lbl_Employee_Detail_List.TabIndex = 0;
            this.lbl_Employee_Detail_List.Text = "Employee Detail List";
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Logout.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.Location = new System.Drawing.Point(739, 2);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(95, 35);
            this.btn_Logout.TabIndex = 2;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_Add_New_Employee
            // 
            this.btn_Add_New_Employee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Add_New_Employee.Location = new System.Drawing.Point(304, 559);
            this.btn_Add_New_Employee.Name = "btn_Add_New_Employee";
            this.btn_Add_New_Employee.Size = new System.Drawing.Size(234, 40);
            this.btn_Add_New_Employee.TabIndex = 1;
            this.btn_Add_New_Employee.Text = "Add New Employee";
            this.btn_Add_New_Employee.UseVisualStyleBackColor = false;
            this.btn_Add_New_Employee.Click += new System.EventHandler(this.btn_Add_New_Employee_Click);
            // 
            // dgv_Employee_Detail_List
            // 
            this.dgv_Employee_Detail_List.AllowUserToAddRows = false;
            this.dgv_Employee_Detail_List.AllowUserToDeleteRows = false;
            this.dgv_Employee_Detail_List.AutoGenerateColumns = false;
            this.dgv_Employee_Detail_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Employee_Detail_List.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Employee_Detail_List.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Employee_Detail_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Employee_Detail_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.mobileNoDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.designationDataGridViewTextBoxColumn});
            this.dgv_Employee_Detail_List.DataSource = this.employeeDetailsBindingSource;
            this.dgv_Employee_Detail_List.Location = new System.Drawing.Point(12, 98);
            this.dgv_Employee_Detail_List.Name = "dgv_Employee_Detail_List";
            this.dgv_Employee_Detail_List.ReadOnly = true;
            this.dgv_Employee_Detail_List.Size = new System.Drawing.Size(810, 437);
            this.dgv_Employee_Detail_List.TabIndex = 3;
            // 
            // empIdDataGridViewTextBoxColumn
            // 
            this.empIdDataGridViewTextBoxColumn.DataPropertyName = "Emp_Id";
            this.empIdDataGridViewTextBoxColumn.HeaderText = "Emp_Id";
            this.empIdDataGridViewTextBoxColumn.Name = "empIdDataGridViewTextBoxColumn";
            this.empIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mobileNoDataGridViewTextBoxColumn
            // 
            this.mobileNoDataGridViewTextBoxColumn.DataPropertyName = "Mobile_No";
            this.mobileNoDataGridViewTextBoxColumn.HeaderText = "Mobile_No";
            this.mobileNoDataGridViewTextBoxColumn.Name = "mobileNoDataGridViewTextBoxColumn";
            this.mobileNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            this.dOBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // designationDataGridViewTextBoxColumn
            // 
            this.designationDataGridViewTextBoxColumn.DataPropertyName = "Designation";
            this.designationDataGridViewTextBoxColumn.HeaderText = "Designation";
            this.designationDataGridViewTextBoxColumn.Name = "designationDataGridViewTextBoxColumn";
            this.designationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeDetailsBindingSource
            // 
            this.employeeDetailsBindingSource.DataMember = "Employee_Details";
            this.employeeDetailsBindingSource.DataSource = this.eMPLOYEE_MANAGEMENT_SYSTEM_DATABASEDataSet;
            // 
            // eMPLOYEE_MANAGEMENT_SYSTEM_DATABASEDataSet
            // 
            this.eMPLOYEE_MANAGEMENT_SYSTEM_DATABASEDataSet.DataSetName = "EMPLOYEE_MANAGEMENT_SYSTEM_DATABASEDataSet";
            this.eMPLOYEE_MANAGEMENT_SYSTEM_DATABASEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empMgtSystemDBDataSetBindingSource
            // 
            this.empMgtSystemDBDataSetBindingSource.DataSource = this.emp_Mgt_System_DBDataSet;
            this.empMgtSystemDBDataSetBindingSource.Position = 0;
            // 
            // emp_Mgt_System_DBDataSet
            // 
            this.emp_Mgt_System_DBDataSet.DataSetName = "Emp_Mgt_System_DBDataSet";
            this.emp_Mgt_System_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empMgtSystemDBBindingSource
            // 
            this.empMgtSystemDBBindingSource.DataSource = this.emp_Mgt_System_DB;
            this.empMgtSystemDBBindingSource.Position = 0;
            // 
            // emp_Mgt_System_DB
            // 
            this.emp_Mgt_System_DB.DataSetName = "Emp_Mgt_System_DB";
            this.emp_Mgt_System_DB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl_Uname
            // 
            this.lbl_Uname.AutoSize = true;
            this.lbl_Uname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbl_Uname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Uname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Uname.Location = new System.Drawing.Point(-1, 2);
            this.lbl_Uname.Name = "lbl_Uname";
            this.lbl_Uname.Size = new System.Drawing.Size(70, 16);
            this.lbl_Uname.TabIndex = 11;
            this.lbl_Uname.Text = "Username";
            // 
            // employee_DetailsTableAdapter
            // 
            this.employee_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // frm_Employee_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(834, 611);
            this.Controls.Add(this.lbl_Uname);
            this.Controls.Add(this.dgv_Employee_Detail_List);
            this.Controls.Add(this.btn_Add_New_Employee);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.lbl_Employee_Detail_List);
            this.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frm_Employee_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee List";
            this.Load += new System.EventHandler(this.frm_Employee_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Employee_Detail_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEE_MANAGEMENT_SYSTEM_DATABASEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empMgtSystemDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emp_Mgt_System_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empMgtSystemDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emp_Mgt_System_DB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Employee_Detail_List;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_Add_New_Employee;
        private System.Windows.Forms.DataGridView dgv_Employee_Detail_List;
        private System.Windows.Forms.BindingSource empMgtSystemDBBindingSource;
        private Emp_Mgt_System_DB emp_Mgt_System_DB;
        private System.Windows.Forms.BindingSource empMgtSystemDBDataSetBindingSource;
        private Emp_Mgt_System_DBDataSet emp_Mgt_System_DBDataSet;
        private System.Windows.Forms.Label lbl_Uname;
        private EMPLOYEE_MANAGEMENT_SYSTEM_DATABASEDataSet eMPLOYEE_MANAGEMENT_SYSTEM_DATABASEDataSet;
        private System.Windows.Forms.BindingSource employeeDetailsBindingSource;
        private EMPLOYEE_MANAGEMENT_SYSTEM_DATABASEDataSetTableAdapters.Employee_DetailsTableAdapter employee_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn empIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn designationDataGridViewTextBoxColumn;
    }
}