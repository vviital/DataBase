namespace Windows
{
    partial class AllPlayers
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
            this.AllPlayersTable = new System.Windows.Forms.DataGridView();
            this.PlayerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlayerLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalGain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlayerRankingLabel = new System.Windows.Forms.Label();
            this.ViewFriendCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.AllPlayersTable)).BeginInit();
            this.SuspendLayout();
            // 
            // AllPlayersTable
            // 
            this.AllPlayersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllPlayersTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PlayerId,
            this.PlayerLogin,
            this.FirstName,
            this.Surname,
            this.TotalGain});
            this.AllPlayersTable.Location = new System.Drawing.Point(28, 42);
            this.AllPlayersTable.Name = "AllPlayersTable";
            this.AllPlayersTable.RowHeadersVisible = false;
            this.AllPlayersTable.Size = new System.Drawing.Size(454, 150);
            this.AllPlayersTable.TabIndex = 0;
            this.AllPlayersTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AllPlayersTable_CellClick);
            // 
            // PlayerId
            // 
            this.PlayerId.HeaderText = "PlayerId";
            this.PlayerId.Name = "PlayerId";
            this.PlayerId.Visible = false;
            // 
            // PlayerLogin
            // 
            this.PlayerLogin.HeaderText = "Player\'s Login";
            this.PlayerLogin.Name = "PlayerLogin";
            this.PlayerLogin.ReadOnly = true;
            this.PlayerLogin.Width = 120;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Width = 120;
            // 
            // Surname
            // 
            this.Surname.HeaderText = "Surname";
            this.Surname.Name = "Surname";
            this.Surname.ReadOnly = true;
            this.Surname.Width = 110;
            // 
            // TotalGain
            // 
            this.TotalGain.HeaderText = "Total Gain";
            this.TotalGain.Name = "TotalGain";
            this.TotalGain.ReadOnly = true;
            // 
            // PlayerRankingLabel
            // 
            this.PlayerRankingLabel.AutoSize = true;
            this.PlayerRankingLabel.Location = new System.Drawing.Point(32, 23);
            this.PlayerRankingLabel.Name = "PlayerRankingLabel";
            this.PlayerRankingLabel.Size = new System.Drawing.Size(81, 13);
            this.PlayerRankingLabel.TabIndex = 1;
            this.PlayerRankingLabel.Text = "Player\'s ranking";
            // 
            // ViewFriendCheckBox
            // 
            this.ViewFriendCheckBox.AutoSize = true;
            this.ViewFriendCheckBox.Location = new System.Drawing.Point(373, 19);
            this.ViewFriendCheckBox.Name = "ViewFriendCheckBox";
            this.ViewFriendCheckBox.Size = new System.Drawing.Size(105, 17);
            this.ViewFriendCheckBox.TabIndex = 2;
            this.ViewFriendCheckBox.Text = "View Friend Only";
            this.ViewFriendCheckBox.UseVisualStyleBackColor = true;
            this.ViewFriendCheckBox.CheckedChanged += new System.EventHandler(this.ViewFriendCheckBox_CheckedChanged);
            // 
            // AllPlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 221);
            this.Controls.Add(this.ViewFriendCheckBox);
            this.Controls.Add(this.PlayerRankingLabel);
            this.Controls.Add(this.AllPlayersTable);
            this.Name = "AllPlayers";
            this.Text = "AllPlayers";
            ((System.ComponentModel.ISupportInitialize)(this.AllPlayersTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AllPlayersTable;
        private System.Windows.Forms.Label PlayerRankingLabel;
        private System.Windows.Forms.CheckBox ViewFriendCheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalGain;
    }
}