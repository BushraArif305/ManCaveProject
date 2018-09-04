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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlParent.Controls.Clear();
        }

        private void menuItemDashBoard_Click(object sender, EventArgs e)
        {
            ShowMenuForm(new DashBoard());
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowMenuForm(new AddUser());
        }

        private void assignJudgeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowMenuForm(new AssignJudges());
        }

        private void userListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowMenuForm(new UserList());
        }

        private void playerListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowMenuForm(new PlayerList());
        }

        void ShowMenuForm(Form fm)
        {
            if (pnlParent.Controls.Count > 0) (pnlParent.Controls[0] as Form).Close();
            pnlParent.Controls.Clear();
            fm.TopLevel = false;
            pnlParent.Controls.Add(fm);
            fm.Dock = DockStyle.Fill;
            fm.Show();
        }
    }
}
