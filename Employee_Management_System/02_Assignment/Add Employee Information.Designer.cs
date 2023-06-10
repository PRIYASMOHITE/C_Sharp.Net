namespace Employee_Management_System
{
    partial class frm_Add_New_Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Add_New_Employee));
            this.lbl_Add_Employee_Info = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_mobno = new System.Windows.Forms.Label();
            this.lbl_dob = new System.Windows.Forms.Label();
            this.lbl_designation = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_Mob_No = new System.Windows.Forms.TextBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.dtp_dob = new System.Windows.Forms.DateTimePicker();
            this.cmb_Des = new System.Windows.Forms.ComboBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_emp_list = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.lbl_Uname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Add_Employee_Info
            // 
            this.lbl_Add_Employee_Info.AutoSize = true;
            this.lbl_Add_Employee_Info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbl_Add_Employee_Info.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_Employee_Info.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Add_Employee_Info.Location = new System.Drawing.Point(164, 38);
            this.lbl_Add_Employee_Info.Name = "lbl_Add_Employee_Info";
            this.lbl_Add_Employee_Info.Size = new System.Drawing.Size(430, 36);
            this.lbl_Add_Employee_Info.TabIndex = 0;
            this.lbl_Add_Employee_Info.Text = "Add Employee Information";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lbl_id.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.ForeColor = System.Drawing.Color.Purple;
            this.lbl_id.Location = new System.Drawing.Point(61, 134);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(41, 31);
            this.lbl_id.TabIndex = 1;
            this.lbl_id.Text = "ID";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lbl_Name.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.ForeColor = System.Drawing.Color.Purple;
            this.lbl_Name.Location = new System.Drawing.Point(61, 218);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(77, 31);
            this.lbl_Name.TabIndex = 2;
            this.lbl_Name.Text = "Name";
            // 
            // lbl_mobno
            // 
            this.lbl_mobno.AutoSize = true;
            this.lbl_mobno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lbl_mobno.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mobno.ForeColor = System.Drawing.Color.Purple;
            this.lbl_mobno.Location = new System.Drawing.Point(61, 289);
            this.lbl_mobno.Name = "lbl_mobno";
            this.lbl_mobno.Size = new System.Drawing.Size(133, 31);
            this.lbl_mobno.TabIndex = 3;
            this.lbl_mobno.Text = "Mobile No";
            // 
            // lbl_dob
            // 
            this.lbl_dob.AutoSize = true;
            this.lbl_dob.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lbl_dob.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dob.ForeColor = System.Drawing.Color.Purple;
            this.lbl_dob.Location = new System.Drawing.Point(61, 371);
            this.lbl_dob.Name = "lbl_dob";
            this.lbl_dob.Size = new System.Drawing.Size(91, 31);
            this.lbl_dob.TabIndex = 4;
            this.lbl_dob.Text = "D.O.B.";
            // 
            // lbl_designation
            // 
            this.lbl_designation.AutoSize = true;
            this.lbl_designation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lbl_designation.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_designation.ForeColor = System.Drawing.Color.Purple;
            this.lbl_designation.Location = new System.Drawing.Point(61, 447);
            this.lbl_designation.Name = "lbl_designation";
            this.lbl_designation.Size = new System.Drawing.Size(143, 31);
            this.lbl_designation.TabIndex = 5;
            this.lbl_designation.Text = "Designation";
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.Location = new System.Drawing.Point(557, 214);
            this.tb_name.MaxLength = 20;
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(229, 35);
            this.tb_name.TabIndex = 2;
            this.tb_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Text);
            // 
            // tb_Mob_No
            // 
            this.tb_Mob_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mob_No.Location = new System.Drawing.Point(557, 287);
            this.tb_Mob_No.MaxLength = 10;
            this.tb_Mob_No.Name = "tb_Mob_No";
            this.tb_Mob_No.Size = new System.Drawing.Size(229, 35);
            this.tb_Mob_No.TabIndex = 3;
            this.tb_Mob_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // tb_id
            // 
            this.tb_id.Enabled = false;
            this.tb_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_id.Location = new System.Drawing.Point(557, 130);
            this.tb_id.MaxLength = 5;
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(229, 35);
            this.tb_id.TabIndex = 1;
            this.tb_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // dtp_dob
            // 
            this.dtp_dob.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_dob.Location = new System.Drawing.Point(557, 367);
            this.dtp_dob.Name = "dtp_dob";
            this.dtp_dob.Size = new System.Drawing.Size(229, 35);
            this.dtp_dob.TabIndex = 4;
            // 
            // cmb_Des
            // 
            this.cmb_Des.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Des.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Des.FormattingEnabled = true;
            this.cmb_Des.Items.AddRange(new object[] {
            "Manager",
            "Tester",
            "Developer"});
            this.cmb_Des.Location = new System.Drawing.Point(557, 441);
            this.cmb_Des.Name = "cmb_Des";
            this.cmb_Des.Size = new System.Drawing.Size(229, 37);
            this.cmb_Des.TabIndex = 5;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Save.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.Black;
            this.btn_Save.Location = new System.Drawing.Point(334, 532);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(111, 49);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(53, 531);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(141, 49);
            this.btn_Refresh.TabIndex = 7;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_emp_list
            // 
            this.btn_emp_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_emp_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_emp_list.Location = new System.Drawing.Point(557, 531);
            this.btn_emp_list.Name = "btn_emp_list";
            this.btn_emp_list.Size = new System.Drawing.Size(229, 50);
            this.btn_emp_list.TabIndex = 8;
            this.btn_emp_list.Text = "Employee List";
            this.btn_emp_list.UseVisualStyleBackColor = false;
            this.btn_emp_list.Click += new System.EventHandler(this.btn_emp_list_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Logout.Font = new System.Drawing.Font("Lucida Calligraphy", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.Location = new System.Drawing.Point(758, 0);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(75, 23);
            this.btn_Logout.TabIndex = 9;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // lbl_Uname
            // 
            this.lbl_Uname.AutoSize = true;
            this.lbl_Uname.BackColor = System.Drawing.Color.Fuchsia;
            this.lbl_Uname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Uname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Uname.Location = new System.Drawing.Point(2, 2);
            this.lbl_Uname.Name = "lbl_Uname";
            this.lbl_Uname.Size = new System.Drawing.Size(70, 16);
            this.lbl_Uname.TabIndex = 10;
            this.lbl_Uname.Text = "Username";
            // 
            // frm_Add_New_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(834, 611);
            this.Controls.Add(this.lbl_Uname);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.btn_emp_list);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.cmb_Des);
            this.Controls.Add(this.dtp_dob);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.tb_Mob_No);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.lbl_designation);
            this.Controls.Add(this.lbl_dob);
            this.Controls.Add(this.lbl_mobno);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.lbl_Add_Employee_Info);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Add_New_Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add  Employee Information";
            this.Load += new System.EventHandler(this.frm_Add_New_Employee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Add_Employee_Info;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_mobno;
        private System.Windows.Forms.Label lbl_dob;
        private System.Windows.Forms.Label lbl_designation;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_Mob_No;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.DateTimePicker dtp_dob;
        private System.Windows.Forms.ComboBox cmb_Des;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_emp_list;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Label lbl_Uname;
    }
}