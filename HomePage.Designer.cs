namespace ManCaveLeague
{
    partial class HomePage
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
            this.pnlParent = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDashBoard = new System.Windows.Forms.ToolStripMenuItem();
            this.scoreBoardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignJudgeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameReport1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameReport2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addLeagueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addLeagueToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllLeaguesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlParent
            // 
            this.pnlParent.BackColor = System.Drawing.Color.Transparent;
            this.pnlParent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlParent.Location = new System.Drawing.Point(246, 0);
            this.pnlParent.Name = "pnlParent";
            this.pnlParent.Size = new System.Drawing.Size(616, 606);
            this.pnlParent.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.toolStripMenuItem2,
            this.scoreBoardToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.gameReportToolStripMenuItem,
            this.addLeagueToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(246, 606);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.homeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(233, 49);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemDashBoard});
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(233, 49);
            this.toolStripMenuItem2.Text = "League Games";
            // 
            // menuItemDashBoard
            // 
            this.menuItemDashBoard.Name = "menuItemDashBoard";
            this.menuItemDashBoard.Size = new System.Drawing.Size(262, 50);
            this.menuItemDashBoard.Text = "Dash Board";
            this.menuItemDashBoard.Click += new System.EventHandler(this.menuItemDashBoard_Click);
            // 
            // scoreBoardToolStripMenuItem
            // 
            this.scoreBoardToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.scoreBoardToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.scoreBoardToolStripMenuItem.Name = "scoreBoardToolStripMenuItem";
            this.scoreBoardToolStripMenuItem.Size = new System.Drawing.Size(233, 49);
            this.scoreBoardToolStripMenuItem.Text = "Score Board";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem,
            this.assignJudgeToolStripMenuItem,
            this.userListToolStripMenuItem,
            this.playerListToolStripMenuItem});
            this.usersToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.usersToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(233, 49);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(287, 50);
            this.addUserToolStripMenuItem.Text = "Add User";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // assignJudgeToolStripMenuItem
            // 
            this.assignJudgeToolStripMenuItem.Name = "assignJudgeToolStripMenuItem";
            this.assignJudgeToolStripMenuItem.Size = new System.Drawing.Size(287, 50);
            this.assignJudgeToolStripMenuItem.Text = "Assign Judge";
            this.assignJudgeToolStripMenuItem.Click += new System.EventHandler(this.assignJudgeToolStripMenuItem_Click);
            // 
            // userListToolStripMenuItem
            // 
            this.userListToolStripMenuItem.Name = "userListToolStripMenuItem";
            this.userListToolStripMenuItem.Size = new System.Drawing.Size(287, 50);
            this.userListToolStripMenuItem.Text = "User List";
            this.userListToolStripMenuItem.Click += new System.EventHandler(this.userListToolStripMenuItem_Click);
            // 
            // playerListToolStripMenuItem
            // 
            this.playerListToolStripMenuItem.Name = "playerListToolStripMenuItem";
            this.playerListToolStripMenuItem.Size = new System.Drawing.Size(287, 50);
            this.playerListToolStripMenuItem.Text = "Player List";
            this.playerListToolStripMenuItem.Click += new System.EventHandler(this.playerListToolStripMenuItem_Click);
            // 
            // gameReportToolStripMenuItem
            // 
            this.gameReportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameReport1ToolStripMenuItem,
            this.gameReport2ToolStripMenuItem});
            this.gameReportToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.gameReportToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.gameReportToolStripMenuItem.Name = "gameReportToolStripMenuItem";
            this.gameReportToolStripMenuItem.Size = new System.Drawing.Size(233, 49);
            this.gameReportToolStripMenuItem.Text = "Game Reports";
            // 
            // gameReport1ToolStripMenuItem
            // 
            this.gameReport1ToolStripMenuItem.Name = "gameReport1ToolStripMenuItem";
            this.gameReport1ToolStripMenuItem.Size = new System.Drawing.Size(314, 50);
            this.gameReport1ToolStripMenuItem.Text = "Game Report 1";
            // 
            // gameReport2ToolStripMenuItem
            // 
            this.gameReport2ToolStripMenuItem.Name = "gameReport2ToolStripMenuItem";
            this.gameReport2ToolStripMenuItem.Size = new System.Drawing.Size(314, 50);
            this.gameReport2ToolStripMenuItem.Text = "Game Report 2";
            // 
            // addLeagueToolStripMenuItem
            // 
            this.addLeagueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addLeagueToolStripMenuItem1,
            this.viewAllLeaguesToolStripMenuItem});
            this.addLeagueToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.addLeagueToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.addLeagueToolStripMenuItem.Name = "addLeagueToolStripMenuItem";
            this.addLeagueToolStripMenuItem.Size = new System.Drawing.Size(233, 49);
            this.addLeagueToolStripMenuItem.Text = "League";
            // 
            // addLeagueToolStripMenuItem1
            // 
            this.addLeagueToolStripMenuItem1.Name = "addLeagueToolStripMenuItem1";
            this.addLeagueToolStripMenuItem1.Size = new System.Drawing.Size(339, 50);
            this.addLeagueToolStripMenuItem1.Text = "Add League";
            // 
            // viewAllLeaguesToolStripMenuItem
            // 
            this.viewAllLeaguesToolStripMenuItem.Name = "viewAllLeaguesToolStripMenuItem";
            this.viewAllLeaguesToolStripMenuItem.Size = new System.Drawing.Size(339, 50);
            this.viewAllLeaguesToolStripMenuItem.Text = "View All Leagues";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ManCaveLeague.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(862, 606);
            this.Controls.Add(this.pnlParent);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HomePage";
            this.Text = "Man Cave League";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlParent;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem menuItemDashBoard;
        private System.Windows.Forms.ToolStripMenuItem scoreBoardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignJudgeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playerListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameReport1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameReport2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addLeagueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addLeagueToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewAllLeaguesToolStripMenuItem;
    }
}