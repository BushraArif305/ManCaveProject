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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string name = txtboxUserName.Text;
            string pw = txtboxPassword.Text;

            using (MCLEntities entities = new MCLEntities())
            {
                Configuration.User = entities.Users.Where(x => x.LoginId == name && x.Password == pw).SingleOrDefault();
                if (Configuration.User != null)
                {
                    this.Hide();
                    HomePage homepage = new HomePage();
                    homepage.ShowDialog();
                    this.Close();
                }
                else
                {
                }
            }
        }

        private void txtboxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) btnLogin_Click(null, null);
        }
    }
}
