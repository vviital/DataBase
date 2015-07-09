namespace Windows
{
    partial class MainWindows
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
            this.TournamentTable = new System.Windows.Forms.DataGridView();
            this.TournamentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TournamentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Schedule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rounds = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Administrator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Participants = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GameType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wins = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Show = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ShowPlayersButton = new System.Windows.Forms.Button();
            this.GameTypesComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.TournamentTable)).BeginInit();
            this.SuspendLayout();
            // 
            // TournamentTable
            // 
            this.TournamentTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TournamentTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TournamentId,
            this.TournamentName,
            this.Schedule,
            this.Rounds,
            this.Administrator,
            this.Participants,
            this.GameType,
            this.Wins,
            this.Fee,
            this.Show});
            this.TournamentTable.Location = new System.Drawing.Point(12, 62);
            this.TournamentTable.Name = "TournamentTable";
            this.TournamentTable.RowHeadersVisible = false;
            this.TournamentTable.Size = new System.Drawing.Size(854, 150);
            this.TournamentTable.TabIndex = 3;
            this.TournamentTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TournamentTable_CellContentClick);
            // 
            // TournamentId
            // 
            this.TournamentId.HeaderText = "TournamentId";
            this.TournamentId.Name = "TournamentId";
            this.TournamentId.Visible = false;
            // 
            // TournamentName
            // 
            this.TournamentName.HeaderText = "Tournament Name";
            this.TournamentName.Name = "TournamentName";
            this.TournamentName.ReadOnly = true;
            // 
            // Schedule
            // 
            this.Schedule.HeaderText = "Schedule";
            this.Schedule.Name = "Schedule";
            this.Schedule.ReadOnly = true;
            // 
            // Rounds
            // 
            this.Rounds.HeaderText = "Rounds";
            this.Rounds.Name = "Rounds";
            this.Rounds.ReadOnly = true;
            // 
            // Administrator
            // 
            this.Administrator.HeaderText = "Administrator";
            this.Administrator.Name = "Administrator";
            this.Administrator.ReadOnly = true;
            // 
            // Participants
            // 
            this.Participants.HeaderText = "Participants";
            this.Participants.Name = "Participants";
            this.Participants.ReadOnly = true;
            // 
            // GameType
            // 
            this.GameType.HeaderText = "GameType";
            this.GameType.Name = "GameType";
            this.GameType.ReadOnly = true;
            // 
            // Wins
            // 
            this.Wins.HeaderText = "Wins";
            this.Wins.Name = "Wins";
            this.Wins.ReadOnly = true;
            this.Wins.Width = 50;
            // 
            // Fee
            // 
            this.Fee.HeaderText = "Fee";
            this.Fee.Name = "Fee";
            this.Fee.ReadOnly = true;
            this.Fee.Width = 80;
            // 
            // Show
            // 
            this.Show.FillWeight = 120F;
            this.Show.HeaderText = "Show";
            this.Show.Name = "Show";
            this.Show.ReadOnly = true;
            this.Show.Text = "";
            this.Show.Width = 120;
            // 
            // ShowPlayersButton
            // 
            this.ShowPlayersButton.Location = new System.Drawing.Point(12, 232);
            this.ShowPlayersButton.Name = "ShowPlayersButton";
            this.ShowPlayersButton.Size = new System.Drawing.Size(854, 23);
            this.ShowPlayersButton.TabIndex = 4;
            this.ShowPlayersButton.Text = "All players";
            this.ShowPlayersButton.UseVisualStyleBackColor = true;
            this.ShowPlayersButton.Click += new System.EventHandler(this.ShowPlayersButton_Click);
            // 
            // GameTypesComboBox
            // 
            this.GameTypesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GameTypesComboBox.FormattingEnabled = true;
            this.GameTypesComboBox.Items.AddRange(new object[] {
            "All types"});
            this.GameTypesComboBox.Location = new System.Drawing.Point(12, 35);
            this.GameTypesComboBox.Name = "GameTypesComboBox";
            this.GameTypesComboBox.Size = new System.Drawing.Size(121, 21);
            this.GameTypesComboBox.TabIndex = 5;
            this.GameTypesComboBox.SelectedIndexChanged += new System.EventHandler(this.GameTypesComboBox_SelectedIndexChanged);
            // 
            // MainWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 267);
            this.Controls.Add(this.GameTypesComboBox);
            this.Controls.Add(this.ShowPlayersButton);
            this.Controls.Add(this.TournamentTable);
            this.Name = "MainWindows";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.TournamentTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ShowPlayersButton;
        private System.Windows.Forms.ComboBox GameTypesComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn TournamentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TournamentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Schedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rounds;
        private System.Windows.Forms.DataGridViewTextBoxColumn Administrator;
        private System.Windows.Forms.DataGridViewTextBoxColumn Participants;
        private System.Windows.Forms.DataGridViewTextBoxColumn GameType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wins;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fee;
        private System.Windows.Forms.DataGridViewButtonColumn Show;
        private System.Windows.Forms.DataGridView TournamentTable;
    }
}

