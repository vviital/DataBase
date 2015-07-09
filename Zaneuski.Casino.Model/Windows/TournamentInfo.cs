using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.DataBaseMethod;
using Windows.Model;

namespace Windows
{
    public partial class TournamentInfo : Form
    {
        private DataBaseWork DataBase { get; set; }

        private PlayerModel Player { get; set; }

        private int TournamentId { get; set; }

        public TournamentInfo()
        {
            InitializeComponent();
        }

        public TournamentInfo(DataBaseWork dataBase, PlayerModel player, int id)
        {
            InitializeComponent();
            this.DataBase = dataBase;
            this.Player = player;
            this.TournamentId = id;
            this.InitializeTable();
        }

        public void InitializeTable()
        {
            TournamentInfoModel info = this.DataBase.GetTournamentInfoModel(this.TournamentId);
            this.RoundTable.Rows.Clear();
            this.TournamentNameText.Text = info.Tournament.TournamentName;
            this.GameTypeText.Text = info.Tournament.GameType;
            this.AdminText.Text = info.Tournament.Admin;
            this.ScheduleText.Text = info.Tournament.Schedule.ToShortDateString();
            this.MinimumNumberOfWinsText.Text = info.Tournament.Wins.ToString();
            this.FeeText.Text = info.Tournament.Fee.ToString();

            for (int i = 0; i < info.Rounds.Count - 1; ++i)
            {
                this.RoundTable.Rows.Add();
            }

            for (int i = 0; i < info.Rounds.Count; ++i)
            {
                this.RoundTable.Rows[i].Cells[0].Value = info.Rounds[i].RoomNumber;
                this.RoundTable.Rows[i].Cells[1].Value = info.Rounds[i].ParticipantsNumber;
            }
            this.RoundTable.Update();
        }
    }
}
