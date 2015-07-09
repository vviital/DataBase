namespace Windows
{
    partial class TournamentInfo
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
            this.TournamentNameLabel = new System.Windows.Forms.Label();
            this.TournamentNameText = new System.Windows.Forms.Label();
            this.GameTypeLabel = new System.Windows.Forms.Label();
            this.GameTypeText = new System.Windows.Forms.Label();
            this.AdminLabel = new System.Windows.Forms.Label();
            this.AdminText = new System.Windows.Forms.Label();
            this.ScheduleLabel = new System.Windows.Forms.Label();
            this.ScheduleText = new System.Windows.Forms.Label();
            this.MinimumNumberOfWinsLabel = new System.Windows.Forms.Label();
            this.MinimumNumberOfWinsText = new System.Windows.Forms.Label();
            this.FeeLabel = new System.Windows.Forms.Label();
            this.FeeText = new System.Windows.Forms.Label();
            this.RoundTable = new System.Windows.Forms.DataGridView();
            this.RoomNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParticipantsNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomsInfoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RoundTable)).BeginInit();
            this.SuspendLayout();
            // 
            // TournamentNameLabel
            // 
            this.TournamentNameLabel.AutoSize = true;
            this.TournamentNameLabel.Location = new System.Drawing.Point(23, 20);
            this.TournamentNameLabel.Name = "TournamentNameLabel";
            this.TournamentNameLabel.Size = new System.Drawing.Size(95, 13);
            this.TournamentNameLabel.TabIndex = 0;
            this.TournamentNameLabel.Text = "Tournament Name";
            // 
            // TournamentNameText
            // 
            this.TournamentNameText.AutoSize = true;
            this.TournamentNameText.Location = new System.Drawing.Point(158, 20);
            this.TournamentNameText.Name = "TournamentNameText";
            this.TournamentNameText.Size = new System.Drawing.Size(35, 13);
            this.TournamentNameText.TabIndex = 1;
            this.TournamentNameText.Text = "Name";
            // 
            // GameTypeLabel
            // 
            this.GameTypeLabel.AutoSize = true;
            this.GameTypeLabel.Location = new System.Drawing.Point(23, 58);
            this.GameTypeLabel.Name = "GameTypeLabel";
            this.GameTypeLabel.Size = new System.Drawing.Size(58, 13);
            this.GameTypeLabel.TabIndex = 2;
            this.GameTypeLabel.Text = "Game type";
            // 
            // GameTypeText
            // 
            this.GameTypeText.AutoSize = true;
            this.GameTypeText.Location = new System.Drawing.Point(158, 58);
            this.GameTypeText.Name = "GameTypeText";
            this.GameTypeText.Size = new System.Drawing.Size(31, 13);
            this.GameTypeText.TabIndex = 3;
            this.GameTypeText.Text = "Type";
            // 
            // AdminLabel
            // 
            this.AdminLabel.AutoSize = true;
            this.AdminLabel.Location = new System.Drawing.Point(23, 95);
            this.AdminLabel.Name = "AdminLabel";
            this.AdminLabel.Size = new System.Drawing.Size(36, 13);
            this.AdminLabel.TabIndex = 4;
            this.AdminLabel.Text = "Admin";
            // 
            // AdminText
            // 
            this.AdminText.AutoSize = true;
            this.AdminText.Location = new System.Drawing.Point(158, 95);
            this.AdminText.Name = "AdminText";
            this.AdminText.Size = new System.Drawing.Size(33, 13);
            this.AdminText.TabIndex = 5;
            this.AdminText.Text = "Login";
            // 
            // ScheduleLabel
            // 
            this.ScheduleLabel.AutoSize = true;
            this.ScheduleLabel.Location = new System.Drawing.Point(23, 131);
            this.ScheduleLabel.Name = "ScheduleLabel";
            this.ScheduleLabel.Size = new System.Drawing.Size(52, 13);
            this.ScheduleLabel.TabIndex = 6;
            this.ScheduleLabel.Text = "Schedule";
            // 
            // ScheduleText
            // 
            this.ScheduleText.AutoSize = true;
            this.ScheduleText.Location = new System.Drawing.Point(158, 131);
            this.ScheduleText.Name = "ScheduleText";
            this.ScheduleText.Size = new System.Drawing.Size(52, 13);
            this.ScheduleText.TabIndex = 7;
            this.ScheduleText.Text = "Schedule";
            // 
            // MinimumNumberOfWinsLabel
            // 
            this.MinimumNumberOfWinsLabel.AutoSize = true;
            this.MinimumNumberOfWinsLabel.Location = new System.Drawing.Point(23, 169);
            this.MinimumNumberOfWinsLabel.Name = "MinimumNumberOfWinsLabel";
            this.MinimumNumberOfWinsLabel.Size = new System.Drawing.Size(72, 13);
            this.MinimumNumberOfWinsLabel.TabIndex = 8;
            this.MinimumNumberOfWinsLabel.Text = "Wins required";
            // 
            // MinimumNumberOfWinsText
            // 
            this.MinimumNumberOfWinsText.AutoSize = true;
            this.MinimumNumberOfWinsText.Location = new System.Drawing.Point(158, 169);
            this.MinimumNumberOfWinsText.Name = "MinimumNumberOfWinsText";
            this.MinimumNumberOfWinsText.Size = new System.Drawing.Size(31, 13);
            this.MinimumNumberOfWinsText.TabIndex = 9;
            this.MinimumNumberOfWinsText.Text = "Wins";
            // 
            // FeeLabel
            // 
            this.FeeLabel.AutoSize = true;
            this.FeeLabel.Location = new System.Drawing.Point(23, 199);
            this.FeeLabel.Name = "FeeLabel";
            this.FeeLabel.Size = new System.Drawing.Size(25, 13);
            this.FeeLabel.TabIndex = 10;
            this.FeeLabel.Text = "Fee";
            // 
            // FeeText
            // 
            this.FeeText.AutoSize = true;
            this.FeeText.Location = new System.Drawing.Point(158, 199);
            this.FeeText.Name = "FeeText";
            this.FeeText.Size = new System.Drawing.Size(25, 13);
            this.FeeText.TabIndex = 11;
            this.FeeText.Text = "Fee";
            // 
            // RoundTable
            // 
            this.RoundTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RoundTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RoomNumber,
            this.ParticipantsNumber});
            this.RoundTable.Location = new System.Drawing.Point(236, 41);
            this.RoundTable.Name = "RoundTable";
            this.RoundTable.RowHeadersVisible = false;
            this.RoundTable.Size = new System.Drawing.Size(305, 171);
            this.RoundTable.TabIndex = 12;
            // 
            // RoomNumber
            // 
            this.RoomNumber.HeaderText = "Room number";
            this.RoomNumber.Name = "RoomNumber";
            this.RoomNumber.ReadOnly = true;
            this.RoomNumber.Width = 150;
            // 
            // ParticipantsNumber
            // 
            this.ParticipantsNumber.HeaderText = "Participants Number";
            this.ParticipantsNumber.Name = "ParticipantsNumber";
            this.ParticipantsNumber.ReadOnly = true;
            this.ParticipantsNumber.Width = 150;
            // 
            // RoomsInfoLabel
            // 
            this.RoomsInfoLabel.AutoSize = true;
            this.RoomsInfoLabel.Location = new System.Drawing.Point(233, 20);
            this.RoomsInfoLabel.Name = "RoomsInfoLabel";
            this.RoomsInfoLabel.Size = new System.Drawing.Size(127, 13);
            this.RoomsInfoLabel.TabIndex = 13;
            this.RoomsInfoLabel.Text = "Information about rounds:";
            // 
            // TournamentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 232);
            this.Controls.Add(this.RoomsInfoLabel);
            this.Controls.Add(this.RoundTable);
            this.Controls.Add(this.FeeText);
            this.Controls.Add(this.FeeLabel);
            this.Controls.Add(this.MinimumNumberOfWinsText);
            this.Controls.Add(this.MinimumNumberOfWinsLabel);
            this.Controls.Add(this.ScheduleText);
            this.Controls.Add(this.ScheduleLabel);
            this.Controls.Add(this.AdminText);
            this.Controls.Add(this.AdminLabel);
            this.Controls.Add(this.GameTypeText);
            this.Controls.Add(this.GameTypeLabel);
            this.Controls.Add(this.TournamentNameText);
            this.Controls.Add(this.TournamentNameLabel);
            this.Name = "TournamentInfo";
            this.Text = "TournamentInfo";
            ((System.ComponentModel.ISupportInitialize)(this.RoundTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TournamentNameLabel;
        private System.Windows.Forms.Label TournamentNameText;
        private System.Windows.Forms.Label GameTypeLabel;
        private System.Windows.Forms.Label GameTypeText;
        private System.Windows.Forms.Label AdminLabel;
        private System.Windows.Forms.Label AdminText;
        private System.Windows.Forms.Label ScheduleLabel;
        private System.Windows.Forms.Label ScheduleText;
        private System.Windows.Forms.Label MinimumNumberOfWinsLabel;
        private System.Windows.Forms.Label MinimumNumberOfWinsText;
        private System.Windows.Forms.Label FeeLabel;
        private System.Windows.Forms.Label FeeText;
        private System.Windows.Forms.DataGridView RoundTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParticipantsNumber;
        private System.Windows.Forms.Label RoomsInfoLabel;
    }
}