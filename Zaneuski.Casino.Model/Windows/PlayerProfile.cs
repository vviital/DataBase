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
    public partial class PlayerProfile : Form
    {
        public delegate void Update();

        public Update UpdateTables;

        private PlayerModel CurrentPlayer { get; set; }
        private PlayerModel Player { get; set; }
        private DataBaseWork dataBase { get; set; }
        private bool change { get; set; }

        public PlayerProfile()
        {
            InitializeComponent();
        }

        public PlayerProfile(PlayerModel player, int id, DataBaseWork dataBase)
        {
            InitializeComponent();
            this.CurrentPlayer = player;
            this.dataBase = dataBase;
            this.Player = this.dataBase.Player(id);
            InitializePlayerProfile();
            this.IsFriendCheckBox.CheckedChanged += this.IsFriendChange;
        }

        private void InitializePlayerProfile()
        {
            PlayerLogin.Text = Player.Login;
            PlayerFirstName.Text = Player.FirstName;
            PlayerSurname.Text = Player.Surname;
            PlayerSex.Text = Player.Sex ? "Male" : "Female";
            PlayerEmail.Text = Player.Email;
            PlayerCountry.Text = Player.Country;

            bool isFriend = this.dataBase.IsFriend(CurrentPlayer, Player);

            this.IsFriendCheckBox.Checked = isFriend;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (this.CurrentPlayer == null)
            {
                return;
            }
            if (this.change)
            {
                if (this.IsFriendCheckBox.Checked)
                {
                    this.dataBase.JoinFriend(this.CurrentPlayer, this.Player);
                }
                else
                {
                    this.dataBase.UnJoinFriend(this.CurrentPlayer, this.Player);
                }
                this.UpdateTables.Invoke();
            }
            this.Close();
        }

        private void IsFriendChange(object sender, EventArgs e)
        {
            this.change ^= true;
        }
    }
}
