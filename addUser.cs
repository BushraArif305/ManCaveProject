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
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
            using (MCLEntities entities = new MCLEntities())
            {
                List<UserType> getUserType = (from a in entities.UserTypes
                                              select a).Where(x => x.UserTypeId != 3).ToList();
                cbUserTypeList.DataSource = getUserType;
                cbUserTypeList.ValueMember = "UserTypeId";
                cbUserTypeList.DisplayMember = "UserType1";
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            using (MCLEntities entities = new MCLEntities())
            {
                User user = new User();

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

                entities.Users.Add(user);
                entities.SaveChanges();
                MessageBox.Show("New User Added.");

                tbFName.Text = "";
                tbLName.Text = "";
                tbLoginId.Text = "";
                tbPW.Text = "";
                tbEmail.Text = "";
                tbContactNo.Text = "";
            }
        }


    }
}
