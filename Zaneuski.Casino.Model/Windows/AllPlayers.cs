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
using Zaneuski.Casino.Model;

namespace Windows
{
    public partial class AllPlayers : Form
    {
        public PlayerModel CurrentPlayer { get; set; }
        private DataBaseWork dataBase { get; set; }

        public AllPlayers()
        {
            InitializeComponent();
        }

        public AllPlayers(PlayerModel player, DataBaseWork dataBase)
        {
            InitializeComponent();
            this.CurrentPlayer = player;
            this.dataBase = dataBase;
            InitializeTable();
        }

        private void InitializeTable()
        {
            List<PlayerRankingModel> model;
            if (this.ViewFriendCheckBox.Checked == false)
            {
                model = this.dataBase.Players();
            }
            else
            {
                model = this.dataBase.Players(CurrentPlayer);
            }
            this.AllPlayersTable.Rows.Clear();
            for (int i = 0; i < model.Count - 1; ++i)
            {
                this.AllPlayersTable.Rows.Add();
            }
            for (int i = 0; i < model.Count; ++i)
            {
                PlayerRankingModel ranking = model[i];
                this.AllPlayersTable.Rows[i].Cells[0].Value = ranking.Id;
                this.AllPlayersTable.Rows[i].Cells[1].Value = ranking.Login;
                this.AllPlayersTable.Rows[i].Cells[2].Value = ranking.FirstName;
                this.AllPlayersTable.Rows[i].Cells[3].Value = ranking.Surname;
                this.AllPlayersTable.Rows[i].Cells[4].Value = ranking.TotalGain;
            }
            this.AllPlayersTable.Update();
        }

        private void AllPlayersTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (CurrentPlayer == null)
            {
                return;
            }
            var senderGrid = (DataGridView)sender;
            if (e.RowIndex >= 0)
            {
                int id = Int32.Parse(senderGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                PlayerProfile profile = new PlayerProfile(CurrentPlayer, id, dataBase);
                profile.Show();
                profile.UpdateTables += InitializeTable;
            }
        }

        private void ViewFriendCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            InitializeTable();
        }
    }
}
