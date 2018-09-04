namespace ManCaveLeague
{
    partial class UserList
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
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoginId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panelEditUser = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EditBtn = new System.Windows.Forms.Button();
            this.tbContactNo = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbPW = new System.Windows.Forms.TextBox();
            this.tbLoginId = new System.Windows.Forms.TextBox();
            this.cbUserTypeList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbLName = new System.Windows.Forms.TextBox();
            this.tbFName = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.panelEditUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AllowUserToResizeColumns = false;
            this.dgvUsers.AllowUserToResizeRows = false;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.FirstName,
            this.LastName,
            this.UserType,
            this.LoginId,
            this.EmailId,
            this.ContactNo,
            this.Edit});
            this.dgvUsers.Location = new System.Drawing.Point(9, 70);
            this.dgvUsers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowTemplate.Height = 24;
            this.dgvUsers.Size = new System.Drawing.Size(1091, 246);
            this.dgvUsers.TabIndex = 0;
            this.dgvUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "User Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            this.FirstName.Width = 150;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            this.LastName.Width = 150;
            // 
            // UserType
            // 
            this.UserType.HeaderText = "User Type";
            this.UserType.Name = "UserType";
            this.UserType.Width = 150;
            // 
            // LoginId
            // 
            this.LoginId.HeaderText = "Login ID";
            this.LoginId.Name = "LoginId";
            this.LoginId.Width = 150;
            // 
            // EmailId
            // 
            this.EmailId.HeaderText = "Email ID";
            this.EmailId.Name = "EmailId";
            this.EmailId.Width = 150;
            // 
            // ContactNo
            // 
            this.ContactNo.HeaderText = "Contact Number";
            this.ContactNo.Name = "ContactNo";
            this.ContactNo.Width = 150;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edit";
            this.Edit.ToolTipText = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            this.Edit.Width = 150;
            // 
            // panelEditUser
            // 
            this.panelEditUser.BackColor = System.Drawing.Color.Transparent;
            this.panelEditUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEditUser.Controls.Add(this.btnCancel);
            this.panelEditUser.Controls.Add(this.label8);
            this.panelEditUser.Controls.Add(this.label7);
            this.panelEditUser.Controls.Add(this.label6);
            this.panelEditUser.Controls.Add(this.label5);
            this.panelEditUser.Controls.Add(this.label4);
            this.panelEditUser.Controls.Add(this.label3);
            this.panelEditUser.Controls.Add(this.label2);
            this.panelEditUser.Controls.Add(this.EditBtn);
            this.panelEditUser.Controls.Add(this.tbContactNo);
            this.panelEditUser.Controls.Add(this.tbEmail);
            this.panelEditUser.Controls.Add(this.tbPW);
            this.panelEditUser.Controls.Add(this.tbLoginId);
            this.panelEditUser.Controls.Add(this.cbUserTypeList);
            this.panelEditUser.Controls.Add(this.label1);
            this.panelEditUser.Controls.Add(this.tbLName);
            this.panelEditUser.Controls.Add(this.tbFName);
            this.panelEditUser.Location = new System.Drawing.Point(186, 20);
            this.panelEditUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelEditUser.Name = "panelEditUser";
            this.panelEditUser.Size = new System.Drawing.Size(593, 541);
            this.panelEditUser.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(212, 413);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Contact No";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(212, 358);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Emai ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(212, 314);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(212, 260);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Login ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 202);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "User Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 152);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "First Name";
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(290, 470);
            this.EditBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(56, 19);
            this.EditBtn.TabIndex = 24;
            this.EditBtn.Text = "Save";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // tbContactNo
            // 
            this.tbContactNo.Location = new System.Drawing.Point(290, 410);
            this.tbContactNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbContactNo.Name = "tbContactNo";
            this.tbContactNo.Size = new System.Drawing.Size(76, 20);
            this.tbContactNo.TabIndex = 23;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(290, 356);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(76, 20);
            this.tbEmail.TabIndex = 22;
            // 
            // tbPW
            // 
            this.tbPW.Location = new System.Drawing.Point(290, 312);
            this.tbPW.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPW.Name = "tbPW";
            this.tbPW.Size = new System.Drawing.Size(76, 20);
            this.tbPW.TabIndex = 21;
            // 
            // tbLoginId
            // 
            this.tbLoginId.Location = new System.Drawing.Point(290, 258);
            this.tbLoginId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbLoginId.Name = "tbLoginId";
            this.tbLoginId.Size = new System.Drawing.Size(76, 20);
            this.tbLoginId.TabIndex = 20;
            // 
            // cbUserTypeList
            // 
            this.cbUserTypeList.FormattingEnabled = true;
            this.cbUserTypeList.Location = new System.Drawing.Point(290, 199);
            this.cbUserTypeList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbUserTypeList.Name = "cbUserTypeList";
            this.cbUserTypeList.Size = new System.Drawing.Size(92, 21);
            this.cbUserTypeList.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Edit Users";
            // 
            // tbLName
            // 
            this.tbLName.Location = new System.Drawing.Point(288, 150);
            this.tbLName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbLName.Name = "tbLName";
            this.tbLName.Size = new System.Drawing.Size(76, 20);
            this.tbLName.TabIndex = 17;
            // 
            // tbFName
            // 
            this.tbFName.Location = new System.Drawing.Point(288, 95);
            this.tbFName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbFName.Name = "tbFName";
            this.tbFName.Size = new System.Drawing.Size(76, 20);
            this.tbFName.TabIndex = 16;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Gray;
            this.btnCancel.BackgroundImage = global::ManCaveLeague.Properties.Resources.Cross;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(557, 6);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(34, 39);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // UserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 595);
            this.ControlBox = false;
            this.Controls.Add(this.panelEditUser);
            this.Controls.Add(this.dgvUsers);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UserList";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.panelEditUser.ResumeLayout(false);
            this.panelEditUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Panel panelEditUser;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.TextBox tbContactNo;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbPW;
        private System.Windows.Forms.TextBox tbLoginId;
        private System.Windows.Forms.ComboBox cbUserTypeList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbLName;
        private System.Windows.Forms.TextBox tbFName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserType;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoginId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactNo;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
    }
}