namespace ManCaveLeague
{
    partial class AssignJudges
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
            this.cbLeagueList = new System.Windows.Forms.ComboBox();
            this.cbGameList = new System.Windows.Forms.ComboBox();
            this.cbJudgeList = new System.Windows.Forms.ComboBox();
            this.dgvAssignJudge = new System.Windows.Forms.DataGridView();
            this.Userid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JudgeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnSelect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignJudge)).BeginInit();
            this.SuspendLayout();
            // 
            // cbLeagueList
            // 
            this.cbLeagueList.FormattingEnabled = true;
            this.cbLeagueList.Location = new System.Drawing.Point(76, 128);
            this.cbLeagueList.Margin = new System.Windows.Forms.Padding(2);
            this.cbLeagueList.Name = "cbLeagueList";
            this.cbLeagueList.Size = new System.Drawing.Size(180, 21);
            this.cbLeagueList.TabIndex = 0;
            this.cbLeagueList.SelectedValueChanged += new System.EventHandler(this.cbLeagueList_SelectedValueChanged);
            // 
            // cbGameList
            // 
            this.cbGameList.FormattingEnabled = true;
            this.cbGameList.Location = new System.Drawing.Point(76, 202);
            this.cbGameList.Margin = new System.Windows.Forms.Padding(2);
            this.cbGameList.Name = "cbGameList";
            this.cbGameList.Size = new System.Drawing.Size(180, 21);
            this.cbGameList.TabIndex = 1;
            this.cbGameList.SelectedValueChanged += new System.EventHandler(this.cbGameList_SelectedValueChanged);
            // 
            // cbJudgeList
            // 
            this.cbJudgeList.FormattingEnabled = true;
            this.cbJudgeList.Location = new System.Drawing.Point(430, 115);
            this.cbJudgeList.Margin = new System.Windows.Forms.Padding(2);
            this.cbJudgeList.Name = "cbJudgeList";
            this.cbJudgeList.Size = new System.Drawing.Size(180, 21);
            this.cbJudgeList.TabIndex = 2;
            // 
            // dgvAssignJudge
            // 
            this.dgvAssignJudge.AllowUserToAddRows = false;
            this.dgvAssignJudge.AllowUserToResizeColumns = false;
            this.dgvAssignJudge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssignJudge.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Userid,
            this.JudgeName,
            this.Remove});
            this.dgvAssignJudge.Location = new System.Drawing.Point(430, 176);
            this.dgvAssignJudge.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAssignJudge.Name = "dgvAssignJudge";
            this.dgvAssignJudge.RowTemplate.Height = 24;
            this.dgvAssignJudge.Size = new System.Drawing.Size(243, 318);
            this.dgvAssignJudge.TabIndex = 3;
            this.dgvAssignJudge.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAssignJudge_CellContentClick);
            // 
            // Userid
            // 
            this.Userid.HeaderText = "User ID";
            this.Userid.Name = "Userid";
            this.Userid.Visible = false;
            // 
            // JudgeName
            // 
            this.JudgeName.HeaderText = "JudgeName";
            this.JudgeName.Name = "JudgeName";
            this.JudgeName.ReadOnly = true;
            // 
            // Remove
            // 
            this.Remove.HeaderText = "Remove";
            this.Remove.Name = "Remove";
            this.Remove.Text = "Remove";
            this.Remove.UseColumnTextForButtonValue = true;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(430, 141);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(56, 19);
            this.btnSelect.TabIndex = 4;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // AssignJudges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 702);
            this.ControlBox = false;
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.dgvAssignJudge);
            this.Controls.Add(this.cbJudgeList);
            this.Controls.Add(this.cbGameList);
            this.Controls.Add(this.cbLeagueList);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AssignJudges";
            this.Load += new System.EventHandler(this.assignJudge_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignJudge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbLeagueList;
        private System.Windows.Forms.ComboBox cbGameList;
        private System.Windows.Forms.ComboBox cbJudgeList;
        private System.Windows.Forms.DataGridView dgvAssignJudge;
        private System.Windows.Forms.DataGridViewTextBoxColumn Userid;
        private System.Windows.Forms.DataGridViewTextBoxColumn JudgeName;
        private System.Windows.Forms.DataGridViewButtonColumn Remove;
        private System.Windows.Forms.Button btnSelect;
    }
}