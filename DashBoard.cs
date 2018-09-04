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
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
            load();
        }

        void load()
        {
            using (MCLEntities entities = new MCLEntities())
            {
                League runningLeague = entities.Leagues.Where(x => x.Status == true).FirstOrDefault();
                lblLeague.Text = runningLeague.Title;

                int?[] allowedGameIds = entities.View_AllJudges.Where(x => x.UserId == Configuration.User.UserId).Select(x => x.GameId).ToArray();

                View_AllGames[] games = entities.View_AllGames.Where(x => x.LeagueId == runningLeague.LeagueId).ToArray();
                //List<View_AllGames> allowedGames = new List<View_AllGames>();
                foreach (View_AllGames game in games)
                {
                    if (allowedGameIds.Contains((int?)game.GameId))
                    {
                        dgvPlayerGame.Rows.Add(game.PlayerGameId,game.PlayerName,game.Game,game.GameStartTime.Value.ToShortDateString(), game.GameStartTime.Value.ToShortTimeString(), game.GameEndTime.Value.ToShortTimeString(), game.CurrentRank,game.CurrentTier,game.TotalPoints,game.GameTierType,game.MarkedByFName + " " + game.MarkedByLName, "View");
                    }
                }
            }
        }

        private void dgvPlayerGame_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell cell = dgvPlayerGame.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (cell.Value.ToString() == "View")
            {
                int playergameid = Convert.ToInt32(dgvPlayerGame.Rows[e.RowIndex].Cells[0].Value);
                JudgeGame jg = new JudgeGame(playergameid);
                jg.TopLevel = false;
                this.Parent.Controls.Add(jg);
                jg.Dock = DockStyle.Fill;
                this.Close();
                jg.Show();
            }
        }
    }
}
