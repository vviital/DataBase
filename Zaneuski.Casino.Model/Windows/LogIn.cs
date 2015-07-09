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
    public partial class LogIn : Form
    {
        public delegate void Enter(PlayerModel player);

        public Enter EnterInSystem;

        private DataBaseWork dataBase { get; set; }

        public LogIn()
        {
            InitializeComponent();
            this.PasswordTextBox.PasswordChar = '*';
        }

        public LogIn(DataBaseWork dataBase)
        {
            InitializeComponent();
            this.PasswordTextBox.PasswordChar = '*';
            this.dataBase = dataBase;
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            string login = this.LoginTextBox.Text;
            string password = this.PasswordTextBox.Text;
            PlayerModel player = this.dataBase.Player(login, password);
            if (player == null)
            {
                MessageBox.Show("Incorrect login or password!!!");
            }
            else
            {
                MessageBox.Show(string.Format("Hello {0} !!!", player.Login));
                EnterInSystem.Invoke(player);
            }
            this.Close();
        }

    }
}
