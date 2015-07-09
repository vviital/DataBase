using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.DataBaseMethod;
using Windows.Model;
using Zaneuski.Casino.Model;

namespace Windows
{
    public partial class MainWindows : Form
    {
        private bool isRegistrated = true;

        private DataBaseWork dataBase;

        private PlayerModel CurrentUser { get; set; }

        public MainWindows()
        {
            dataBase = new DataBaseWork();
            InitializeComponent();
            InitializeTournament();
            InitializeGameTypeComboBox();
            CreateRegistration();
        }

        #region CreateButtons
        private void CreateRegistration()
        {
            Button logIn = new Button();
            logIn.Text = "Log in";
            logIn.Name = "LogInButton";
            logIn.Location = new Point(694, 12);
            logIn.Width = 75;
            logIn.Height = 23;
            logIn.Click += LogIn;

            Button signUp = new Button();
            signUp.Text = "Sign up";
            signUp.Name = "SignUpButton";
            signUp.Location = new Point(787, 12);
            signUp.Width = 75;
            signUp.Height = 23;
            signUp.Click += this.SignUp;

            this.Controls.Add(logIn);
            this.Controls.Add(signUp);
        }

        private void CreatePlayerInterface()
        {
            Button logIn = new Button();
            logIn.Text = "Hello " + this.CurrentUser.Login + "!";
            logIn.Name = "PlayerLoginButton";
            logIn.Location = new Point(654, 12);
            logIn.AutoSize = true;
            logIn.Height = 23;
            logIn.Click += ProfileInfo;

            Button signOut = new Button();
            signOut.Text = "Sign out";
            signOut.Name = "SignOutButton";
            signOut.Location = new Point(787, 12);
            signOut.Width = 75;
            signOut.Height = 23;
            signOut.Click += this.SignOut;

            this.Controls.Add(logIn);
            this.Controls.Add(signOut);
        }

        private void DeleteControl(string text)
        {
            int index = -1;
            for (int i = 0; i < this.Controls.Count; ++i)
            {
                if (this.Controls[i].Name.Equals(text))
                {
                    index = i;
                }
            }
            if (index != -1)
            {
                this.Controls.RemoveAt(index);
            }
        }
        #endregion

        public void InitializeTournament()
        {
            if (CurrentUser == null)
            {
                TournamentTable.Rows.Clear();
                return;
            }
            string type = this.GameTypesComboBox.Text;
            List<TournamentModel> tournaments = dataBase.GetTournaments(type);
            TournamentTable.Rows.Clear();
            for(int i = 0; i < tournaments.Count - 1; ++i)
                TournamentTable.Rows.Add();
            for (int i = 0; i < tournaments.Count; ++i)
            {
                TournamentModel tournament = tournaments[i];
                TournamentTable.Rows[i].Cells[0].Value = tournament.Id;
                TournamentTable.Rows[i].Cells[1].Value = tournament.TournamentName;
                TournamentTable.Rows[i].Cells[2].Value = tournament.Schedule.ToShortDateString();
                TournamentTable.Rows[i].Cells[3].Value = tournament.Rounds;
                TournamentTable.Rows[i].Cells[4].Value = tournament.Admin;
                TournamentTable.Rows[i].Cells[5].Value = tournament.Participants;
                TournamentTable.Rows[i].Cells[6].Value = tournament.GameType;
                TournamentTable.Rows[i].Cells[7].Value = tournament.Wins;
                TournamentTable.Rows[i].Cells[8].Value = tournament.Fee;
                bool reg = this.dataBase.IsRegistrate(CurrentUser, tournament.Id);
                string value = reg ? "Registered" : "Registrate";
                (TournamentTable.Rows[i].Cells[9] as DataGridViewButtonCell).Value = value;
            }
        }

        private void InitializeGameTypeComboBox()
        {
            List<GameTypeModel> model = this.dataBase.GetGameTypes();
            foreach (var gameTypeModel in model)
            {
                this.GameTypesComboBox.Items.Add(gameTypeModel.GameType);
            }
        }

        private void Enter(PlayerModel player)
        {
            DeleteControl("LogInButton");
            DeleteControl("SignUpButton");
            this.CurrentUser = player;
            this.InitializeTournament();
            CreatePlayerInterface();
        }

        #region Events
        private void SignUp(object sender, EventArgs e)
        {
            Registration window = new Registration(this.dataBase);
            window.Show();
        }

        private void LogIn(object sender, EventArgs e)
        {
            Windows.LogIn logIn = new LogIn(this.dataBase);
            logIn.Show();
            logIn.EnterInSystem += this.Enter;
        }

        private void SignOut(object sender, EventArgs e)
        {
            DeleteControl("PlayerLoginButton");
            DeleteControl("SignOutButton");
            CurrentUser = null;
            this.TournamentTable.Rows.Clear();
            CreateRegistration();
        }

        private void ProfileInfo(object sender, EventArgs e)
        {
            if (this.CurrentUser != null)
            {
                ChangeProfile window = new ChangeProfile(CurrentUser, this.dataBase);
                window.Show();
                window.UpdateData += this.UpdatePlayer;
            }
        }

        private void ShowPlayersButton_Click(object sender, EventArgs e)
        {
            if (this.CurrentUser != null)
            {
                AllPlayers window = new AllPlayers(CurrentUser, dataBase);
                window.Show();
            }
        }

        private void TournamentTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.CurrentUser != null)
            {
                var senderGrid = (DataGridView)sender;
                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                {
                    int id = Int32.Parse(senderGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                    if (senderGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.Equals("Registrate"))
                    {
                        this.dataBase.RegistrateToTournament(this.CurrentUser, id);
                        senderGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "Registered";
                    }
                    else
                    {
                        this.dataBase.RemoveRegistrateToTournament(this.CurrentUser, id);
                        senderGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "Registrate";
                    }
                    MessageBox.Show("Operation complete");
                }
                else
                {
                    if (e.RowIndex >= 0)
                    {
                        int id = Int32.Parse(senderGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                        TournamentInfo window = new TournamentInfo(this.dataBase, CurrentUser, id);
                        window.Show();
                    }
                }
            }
        }
        #endregion

        private void GameTypesComboBox_TextUpdate(object sender, EventArgs e)
        {
            InitializeTournament();
        }

        private void GameTypesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitializeTournament();
        }

        private void UpdatePlayer(int id)
        {
            this.CurrentUser = this.dataBase.Player(id);
            this.InitializeTournament();
            DeleteControl("PlayerLoginButton");
            DeleteControl("SignOutButton");
            CreatePlayerInterface();
            Update();
        }
    }
}
