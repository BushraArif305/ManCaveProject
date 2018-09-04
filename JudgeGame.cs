using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManCaveLeague
{
    public partial class JudgeGame : Form
    {
        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool MoveWindow(IntPtr hwnd, int x, int y, int cx, int cy, bool repaint);
        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        private static Dictionary<int, int> tierPoints;
        View_AllGames selectedGame;
//        UDPListener mediaPlayerListener;
        public JudgeGame(int playerGsameId)
        {
            InitializeComponent();
  //          mediaPlayerListener = listener;//
            load(playerGsameId);
        }

        void load(int pgid)
        {
            Configuration.KillMediaPlayerProcess();
            tierPoints = new Dictionary<int, int>();
            using (MCLEntities entities = new MCLEntities())
            {
                lblPromo.Visible = false;
                btnPromo.Visible = false;
                selectedGame = entities.View_AllGames.Where(x => x.PlayerGameId == pgid).FirstOrDefault();
                if ((bool)selectedGame.IsMarked)
                {
                    cmboxResult.Enabled = false;
                }
                else if (selectedGame.GameTierType == "Promo") btnSave.Visible = false;
                lblPlayerName.Text = selectedGame.PlayerName.ToString();
                lblLeague.Text = selectedGame.League;
                lblStartTime.Text = selectedGame.GameStartTime.ToString();
                lblEndTime.Text = selectedGame.GameEndTime.ToString();
                lblGame.Text = selectedGame.Game;

                Tier[] tiers = entities.Tiers.Where(x => x.RankId == selectedGame.CurrentRankId).OrderBy(x => x.Index).ToArray();
                cmbTier.DisplayMember = "Title";
                cmbTier.DataSource = tiers;
                cmbTier.Text = selectedGame.CurrentTier;

                Rank rank = entities.Ranks.Where(x => x.RankId == selectedGame.CurrentRankId).FirstOrDefault();
                int point = (int)rank.TierPoints;
                foreach (Tier tier in tiers)
                {
                    tierPoints.Add(tier.TierId, point);
                    point = point + (int)rank.TierPoints;
                }

                Result[] results = entities.Results.ToArray();
                if (selectedGame.GameTier == "Promo") results = results.Where(x => x.ResultId != 3 && x.ResultId != 5).ToArray();
                cmboxResult.DisplayMember = "Title";
                cmboxResult.DataSource = results;
                cmboxResult.Text = selectedGame.GameResult;

                if (selectedGame.TotalPoints == null) lblTotalPoints.Text = "0";
                else lblTotalPoints.Text = selectedGame.TotalPoints.ToString();

                lblRank.Text = selectedGame.CurrentRank;


                if(selectedGame.RecordingFileName != null) runMediaPlayerProcess(selectedGame.RecordingFileName);

                if (selectedGame.GameTierType != "Promo")
                {
                    #region Game
                    {     
                        if (selectedGame.PromoEnabled)
                        {
                            btnPromo.Text = "Disable";
                            lblPromo.Text = "PROMO ENABLED";
                        }
                        else
                        {
                            btnPromo.Text = "Enable";
                            lblPromo.Text = "PROMO DISABLED";
                        }

                        if ((bool)selectedGame.IsMarked && selectedGame.CurrentTierTypeId == 1)
                        {
                            lblPromo.Visible = true;
                            btnPromo.Visible = true;
                        }
                    }
                    #endregion
                }
                else
                {
                    #region Promo
                    {
                        lblPromo.Visible = false;
                        btnPromo.Visible = false;

                        //        tbPromoTotalPoints.Text = selectedGame.TotalPoints.ToString();


                        //        if (selectedGame.TotalPoints == null) lblTotalPoints.InnerText = "0";
                        //        else lblTotalPoints.InnerText = selectedGame.TotalPoints.ToString();
                    }
                    #endregion
                }
            }
        }
        private void cmboxResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            Result rsult = cmboxResult.SelectedItem as Result;
            if (selectedGame.GameTierType != "Promo")
            {
                int gainpoints = 0;
                Rank rank;
                using (MCLEntities entities = new MCLEntities())
                {
                    rank = entities.Ranks.Where(x => x.RankId == selectedGame.CurrentRankId).FirstOrDefault();
                    if (rsult.ResultId == 1)//Win
                    {
                        gainpoints = (int)entities.LeagueMasters.Where(x => x.LeagueId == selectedGame.LeagueId).FirstOrDefault().WinPoints;
                    }
                    else if (rsult.ResultId == 2)//Loose
                    {
                        gainpoints = (int)entities.LeagueMasters.Where(x => x.LeagueId == selectedGame.LeagueId).FirstOrDefault().LoosePoints;
                    }
                    else if (rsult.ResultId == 3)//Tie
                    {
                        gainpoints = (int)entities.LeagueMasters.Where(x => x.LeagueId == selectedGame.LeagueId).FirstOrDefault().TiePoints;
                    }
                    else if (rsult.ResultId == 4)//None
                    {
                        gainpoints = 0;
                    }
                    else if (rsult.ResultId == 5)//Invalid
                    {
                        gainpoints = (int)entities.LeagueMasters.Where(x => x.LeagueId == selectedGame.LeagueId).FirstOrDefault().InvalidPoints;
                    }
                }
                lblGamePoints.Text = gainpoints.ToString();
                if (cmboxResult.Enabled)
                {
                    int points = Convert.ToInt32(selectedGame.TotalPoints);
                    points = points + gainpoints;
                    lblTotalPoints.Text = points.ToString();
                    int tierId;

                    if (gainpoints != 0)
                    {
                        tierId = getNextTier(points);
                    }
                    else
                    {
                        tierId = (int)selectedGame.CurrentTierId;
                    }
                    setTier(tierId);
                }
            }
            else
            {
                lblGamePoints.Text = "0";
            }

            if (cmboxResult.Enabled && cmbTier.Text == "Promo" && selectedGame.GameTierType != "Promo")
            {
                btnPromo.Visible = true;
                lblPromo.Visible = true;
            }
            else if (selectedGame.GameTierType == "Promo")
            {
                btnPromo.Visible = false;
                lblPromo.Visible = false;

                if ((bool)selectedGame.IsMarked)
                {
                    btnPromote.Visible = false;
                }
                else
                {
                    if (rsult.Title == "Win")
                    {
                        btnPromote.Text = "Promote To Next Rank";
                        btnPromote.Visible = true;
                    }
                    else if (rsult.Title == "Loose")
                    {
                        btnPromote.Text = "Demote from Tier";
                        btnPromote.Visible = true;
                    }
                    else
                    {
                        btnPromote.Visible = false;
                    }
                }
            }
            else
            {
                btnPromo.Visible = false;
                lblPromo.Visible = false;
            }
            //int totalpoints = Convert.ToInt32(lblTotalPoints.InnerText);
            //totalpoints = totalpoints + gainpoints;
            //tbtotalPoints.Text = totalpoints.ToString();
            //dlisttier_SelectedIndexChanged(null, null);
        }

        private int getNextTier(int totalPoints)
        {
            foreach (KeyValuePair<int, int> item in tierPoints)
            {
                if (totalPoints < item.Value)
                    return item.Key;
            }

            return tierPoints.Last().Key;
        }

        void setTier(int tierId)
        {
            foreach (Tier t in cmbTier.Items)
            {
                if(t.TierId == tierId)
                {
                    cmbTier.SelectedItem = t;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (MCLEntities entities = new MCLEntities())
            {
                PlayerGame pg = entities.PlayerGames.Where(x => x.PlayerGameId == selectedGame.PlayerGameId).FirstOrDefault();
                PlayerMaster pm = entities.PlayerMasters.Where(x => x.PlayerMasterId == pg.PlayerMasterId).FirstOrDefault();
                if (cmboxResult.Enabled)
                {
                    pg.ResultId = (cmboxResult.SelectedItem as Result).ResultId;
                    pg.GamePoints = Convert.ToInt32(lblGamePoints.Text);
                    pg.IsMarked = true;
                    pg.MarkedAt = DateTime.Now;
                    pg.MarkedById = Configuration.User.UserId;
                    entities.SaveChanges();


                    pm.TierId = (cmbTier.SelectedItem as Tier).TierId;
                    pm.Points = pm.Points + Convert.ToInt32(lblGamePoints.Text);
                    pm.TotalPoints = Convert.ToInt32(lblTotalPoints.Text);


                    if (btnPromo.Text == "Disable")
                    {
                        pm.PromoEnabled = true;
                        pm.IsPromoBlock = false;
                    }
                    else pm.PromoEnabled = false;

                    entities.SaveChanges();

                    if (pg.ResultId != 4) cmboxResult.Enabled = false;
                }
                else
                {
                    if (btnPromo.Text == "Disable")
                    {
                        pm.PromoEnabled = true;
                        pm.IsPromoBlock = false;
                    }
                    else pm.PromoEnabled = false;
                    entities.SaveChanges();
                }
            }

        }

        private void btnPromote_Click(object sender, EventArgs e)
        {
            btnPromote.Visible = false;
            cmboxResult.Enabled = false;
            cmbPromoTier.DataSource = null;
            lblPromoRank.Text = "";
            pnlPromo.Visible = true;
            if (btnPromote.Text == "Demote from Tier")
            {
                using (MCLEntities entities = new MCLEntities())
                {
                    View_AllGames game = entities.View_AllGames.Where(x => x.PlayerGameId == selectedGame.PlayerGameId).FirstOrDefault();
                    Tier[] tiers = entities.Tiers.Where(x => x.RankId == game.CurrentRankId && x.TierTypeId!=1).OrderBy(x => x.Index).ToArray();
                    cmbPromoTier.DisplayMember = "Title";
                    cmbPromoTier.DataSource = tiers;
                    cmbPromoTier.Text = game.CurrentTier;

                    cmbPromoTier.SelectedIndex = tiers.Length - 1;
                    lblPromoRank.Text = game.CurrentRank;
                }
            }
            else
            {
                using (MCLEntities entities = new MCLEntities())
                {
                    View_AllGames game = entities.View_AllGames.Where(x => x.PlayerGameId == selectedGame.PlayerGameId).FirstOrDefault();
                    Rank nextrank = entities.Ranks.Where(x => x.LeagueId == selectedGame.LeagueId && x.Index > game.CurrentRankIndex).OrderBy(x => x.Index).FirstOrDefault();
                    if (nextrank != null)
                    {
                        Tier[] tiers = entities.Tiers.Where(x => x.RankId == nextrank.RankId && x.TierTypeId != 1).OrderBy(x => x.Index).ToArray();
                        cmbPromoTier.DisplayMember = "Title";
                        cmbPromoTier.DataSource = tiers;

                        cmbPromoTier.SelectedIndex = 0;
                        lblPromoRank.Text = nextrank.Title;
                    }
                    else
                    {
                        MessageBox.Show("Alert", "Next Tier is not available", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btnPromo_Click(object sender, EventArgs e)
        {
            if (btnPromo.Text == "Disable")
            {
                btnPromo.Text = "Enable";
                lblPromo.Text = "PROMO DISABLED";
            }
            else
            {
                btnPromo.Text = "Disable";
                lblPromo.Text = "PROMO ENABLED";
            }
        }

        private void cmbPromoTier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPromoTier.SelectedIndex < 0) return;
            using (MCLEntities entities = new MCLEntities())
            {
                Tier t = entities.Tiers.Where(x => x.TierId == selectedGame.CurrentTierId).FirstOrDefault();

                if (btnPromote.Text == "Demote from Tier")
                {
                    int tPoints = tierPoints[(cmbPromoTier.SelectedItem as Tier).TierId];
                    int extraPoints = tPoints - (int)selectedGame.TotalPoints;
                    lblExtraPoints.Text = extraPoints.ToString();
                    lblTotalPoints.Text = (selectedGame.TotalPoints + extraPoints).ToString();
                }
                else
                {
                    if (cmbPromoTier.SelectedIndex == 0)
                    {
                        lblExtraPoints.Text = "0";
                        lblTotalPoints.Text = selectedGame.TotalPoints.ToString();
                    }
                    else
                    {
                        int tPoints = ((int)entities.Ranks.Where(x => x.RankId == selectedGame.CurrentRankId).FirstOrDefault().TierPoints) * cmbPromoTier.SelectedIndex;                  
                        lblExtraPoints.Text = tPoints.ToString();
                        lblTotalPoints.Text = (selectedGame.TotalPoints + tPoints).ToString();
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnPromote.Visible = true;
            cmboxResult.Enabled = true;
            pnlPromo.Visible = false;
            lblTotalPoints.Text = selectedGame.TotalPoints.ToString();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            btnPromote.Visible = false;
            cmboxResult.Enabled = false;
            pnlPromo.Visible = false;
            lblTotalPoints.Text = selectedGame.TotalPoints.ToString();
            
            using (MCLEntities entities = new MCLEntities())
            {
                PlayerGame pg = entities.PlayerGames.Where(x => x.PlayerGameId == selectedGame.PlayerGameId).FirstOrDefault();
                PlayerMaster pm = entities.PlayerMasters.Where(x => x.PlayerMasterId == pg.PlayerMasterId).FirstOrDefault();
                pg.ResultId = (cmboxResult.SelectedItem as Result).ResultId;
                pg.GamePoints = Convert.ToInt32(lblExtraPoints.Text);
                pg.IsMarked = true;
                pg.MarkedAt = DateTime.Now;
                pg.MarkedById = Configuration.User.UserId;
                entities.SaveChanges();


                pm.TierId = (cmbPromoTier.SelectedItem as Tier).TierId;
                pm.Points = 0;
                pm.TotalPoints = Convert.ToInt32(lblTotalPoints.Text);

                pm.PromoEnabled = false;
                pm.IsPromoBlock = false;
                entities.SaveChanges();
            }
        }
        
        private void runMediaPlayerProcess(string url)
        {
            ProcessStartInfo startinfo = new ProcessStartInfo();
            startinfo.FileName = @"D:\MCL Projects\MediaPlayerControl\bin\Debug\MediaPlayerControl.exe";
            //url = @"E:\MCL Videos\Wildlife.wmv";
            //url = @"E:\MCL Videos\7-0-3-30032018124327.mp4";
            //url = @"\\192.168.0.216\MCL Videos\Wildlife.wmv";
            startinfo.Arguments = url + " " + 7009.ToString();

            Process mediaPlayerProcess = new Process();
            mediaPlayerProcess.StartInfo = startinfo;
            mediaPlayerProcess.Start();
            IntPtr ptr = IntPtr.Zero;
            while ((ptr = mediaPlayerProcess.MainWindowHandle) == IntPtr.Zero) ;
            SetParent(mediaPlayerProcess.MainWindowHandle, pnlMediaPlayer.Handle);
            MoveWindow(mediaPlayerProcess.MainWindowHandle, 0, 0, pnlMediaPlayer.Width, pnlMediaPlayer.Height, true);
            

            try
            {
                Thread.Sleep(10);
                Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram,ProtocolType.Udp);
                IPAddress serverAddr = IPAddress.Parse(Configuration.SystemIp);
                IPEndPoint endPoint = new IPEndPoint(serverAddr, 7009);
                string text = "9,0";
                byte[] send_buffer = Encoding.ASCII.GetBytes(text);
                sock.SendTo(send_buffer, endPoint);
            }
            catch(Exception ex) { }

        }
        

    }
}
