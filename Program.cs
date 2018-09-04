using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManCaveLeague
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (MCLEntities entities = new MCLEntities())
            {
                Configuration.User = entities.Users.Where(x => x.LoginId == "tahir" && x.Password == "dcc").SingleOrDefault();
            }
                Application.Run(new HomePage());//LoginForm
        }
    }
}
