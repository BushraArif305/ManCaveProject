using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManCaveLeague
{
    public partial class UserList : Form
    {
        int userId;
        public UserList()
        {
            InitializeComponent();
            load();
        }
        private void load()
        {
            panelEditUser.Visible = false;
            dgvUsers.Rows.Clear();

            using (MCLEntities Entities = new MCLEntities())
            {

                List<UserType> getUserType = (from a in Entities.UserTypes
                                              select a).ToList();
                cbUserTypeList.DataSource = getUserType;
                cbUserTypeList.ValueMember = "UserTypeId";
                cbUserTypeList.DisplayMember = "UserType1";

                var Users = (from a in Entities.Users
                             select a).ToList();
                foreach (User users in Users)
                {
                    var UserType = (from a in Entities.UserTypes
                                    where a.UserTypeId == users.UserTypeId
                                    select a).FirstOrDefault();
                    dgvUsers.Rows.Add(users.UserId, users.FirstName, users.LastName, UserType.UserType1, users.LoginId, users.EmailId, users.ContactNumber);
                }
            }
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvUsers.Columns["Edit"].Index)
            {
                panelEditUser.Visible = true;
                using (MCLEntities Entities = new MCLEntities())
                {
                    userId = Int32.Parse(dgvUsers.Rows[e.RowIndex].Cells[0].Value.ToString());

                    var User = (from a in Entities.Users
                                where a.UserId == userId
                                select a).FirstOrDefault();

                    tbFName.Text = User.FirstName;
                    tbLName.Text = User.LastName;

                    cbUserTypeList.SelectedValue = Int32.Parse(User.UserTypeId.ToString());

                    tbLoginId.Text = User.LoginId;
                    tbPW.Text = User.Password;
                    tbEmail.Text = User.EmailId;
                    tbContactNo.Text = User.ContactNumber;

                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panelEditUser.Visible = false;
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            using (MCLEntities Entities = new MCLEntities())
            {

                var user = (from a in Entities.Users
                            where a.UserId == userId
                            select a).FirstOrDefault();

                if (!(string.IsNullOrEmpty(tbFName.Text)))
                { user.FirstName = tbFName.Text.ToString(); }
                else
                {
                    MessageBox.Show("Enter First Name");
                    tbFName.Focus();
                    return;
                }

                if (!(string.IsNullOrEmpty(tbLName.Text)))
                { user.LastName = tbLName.Text.ToString(); }
                else
                {
                    MessageBox.Show("Enter Last Name");
                    tbLName.Focus();
                    return;
                }

                user.UserTypeId = Int32.Parse(cbUserTypeList.SelectedValue.ToString());

                if (!(string.IsNullOrEmpty(tbLoginId.Text)))
                { user.LoginId = tbLoginId.Text.ToString(); }
                else
                {
                    MessageBox.Show("Enter Login ID");
                    tbLoginId.Focus();
                    return;
                }


                if (!(string.IsNullOrEmpty(tbPW.Text)))
                { user.Password = tbPW.Text.ToString(); }
                else
                {
                    MessageBox.Show("Enter Password");
                    tbPW.Focus();
                    return;
                }

                if (!(string.IsNullOrEmpty(tbEmail.Text)))
                { user.EmailId = tbEmail.Text.ToString(); }
                else
                {
                 
                }

                if (!(string.IsNullOrEmpty(tbContactNo.Text)))
                { user.ContactNumber = tbContactNo.Text.ToString(); }
                else
                {
                   
                }
                Entities.SaveChanges();
                MessageBox.Show("User Updated.");
                load();
            }
        }

    }
}
