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
    public partial class AssignJudges : Form
    {
        public AssignJudges()
        {
            InitializeComponent();
        }

        private void assignJudge_Load(object sender, EventArgs e)
        {
            dgvAssignJudge.Rows.Clear();
            FillLists();
        }

        public void FillLists()
        {
            using (MCLEntities entities = new MCLEntities())
            {
                List<League> leagues = (from a in entities.Leagues
                                        select a).ToList();

                cbLeagueList.ValueMember = "LeagueId";
                cbLeagueList.DisplayMember = "Title";
                cbLeagueList.DataSource = leagues;
                cbLeagueList.SelectedIndex = 0;

                List<User> Users = (from a in entities.Users
                                    where a.UserTypeId == 2
                                    select a).ToList();
                cbJudgeList.ValueMember = "UserId";
                cbJudgeList.DisplayMember = "FirstName";
                cbJudgeList.DataSource = Users;
                cbJudgeList.SelectedIndex = 0;


            }
        }


        private void cbLeagueList_SelectedValueChanged(object sender, EventArgs e)
        {
            dgvAssignJudge.Rows.Clear();
            using (MCLEntities entities = new MCLEntities())
            {
                int lid = Convert.ToInt32(cbLeagueList.SelectedValue);
                //var leagueGames = from t1 in entities.LeagueMasters
                //                  join t2 in entities.Games on t1.GameId equals t2.GameId
                //                  where t1.LeagueId == lid
                //                  select new { t1.LeagueMasterId, t2.Title };
                View_AllGamesOfLeague[] leagueGames = entities.View_AllGamesOfLeague.Where(x => x.LeagueId == lid).ToArray();
                if (leagueGames.Any())
                {


                    cbGameList.ValueMember = "LeagueMasterId";
                    cbGameList.DisplayMember = "Title";
                    cbGameList.DataSource = leagueGames;
                    //cbGameList.SelectedIndex = 0;
                }

            }

        }

        private void cbGameList_SelectedValueChanged(object sender, EventArgs e)
        {
            dgvAssignJudge.Rows.Clear();
            using (MCLEntities entities = new MCLEntities())
            {
                int gid = Convert.ToInt32(cbGameList.SelectedValue);
                //int lid = Convert.ToInt32(cbLeagueList.SelectedValue);
                //var lm = (from y in entities.LeagueMasters
                //          where y.GameId == gid && y.LeagueId == lid
                //          select y).FirstOrDefault();
                //if (lm != null)
                //{
                    //int lmid = lm.LeagueMasterId;
                    LeagueJudge[] leagueJudges = entities.LeagueJudges.Where(x => x.LeagueMasterId == gid).ToArray();
                    foreach (LeagueJudge lj in leagueJudges)
                    {
                        dgvAssignJudge.Rows.Add(lj.UserId, lj.User.FirstName);
                    }
                //}
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            
            foreach(DataGridViewRow row in dgvAssignJudge.Rows)
            {
                if (Int32.Parse(row.Cells[0].Value.ToString()) == Int32.Parse(cbJudgeList.SelectedValue.ToString()))
                {
                    MessageBox.Show("Judge Already Assigned");
                    return;
                }
            }
            dgvAssignJudge.Rows.Add(cbJudgeList.SelectedValue, cbJudgeList.Text);
            int gid = Convert.ToInt32(cbGameList.SelectedValue);
            using (MCLEntities Entities = new MCLEntities())
            {
                    LeagueJudge lj = new LeagueJudge();
                    lj.LeagueMasterId = gid;
                    lj.UserId = Int32.Parse(cbJudgeList.SelectedValue.ToString());
                    Entities.LeagueJudges.Add(lj);
                
                Entities.SaveChanges();
            }
        }

        private void dgvAssignJudge_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvAssignJudge.Columns["Remove"].Index)
            {
               
                using (MCLEntities Entities = new MCLEntities())
                {
                    int gid = Convert.ToInt32(cbGameList.SelectedValue);
                    int userid = Int32.Parse(dgvAssignJudge.Rows[e.RowIndex].Cells[0].Value.ToString());
                    var lj = (from y in Entities.LeagueJudges
                                         where y.LeagueMasterId == gid && y.UserId== userid
                    select y).FirstOrDefault();
                    Entities.LeagueJudges.Remove(lj);
                    Entities.SaveChanges();
                }
                dgvAssignJudge.Rows.Remove(dgvAssignJudge.Rows[e.RowIndex]);
            }
        }
    }
}
