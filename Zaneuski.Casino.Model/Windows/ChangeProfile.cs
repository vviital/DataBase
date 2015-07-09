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
    public partial class ChangeProfile : Form
    {
        public delegate void Update(int id);

        private DataBaseWork dataBase { get; set; }

        private PlayerModel player { get; set; }

        private Dictionary<string, int> dictionary { get; set; }

        public Update UpdateData;

        public ChangeProfile()
        {
            InitializeComponent();
        }

        private void InitializeProfile()
        {
            this.LoginTextBox.Text = player.Login;
            this.PasswordTextBox.Text = player.Password;
            this.FirstNameTextBox.Text = player.FirstName;
            this.SurnameTextBox.Text = player.Surname;
            this.SexComboBox.Text = player.Sex ? "Male" : "Female";
            this.EmailTextBox.Text = player.Email;
            this.CountryComboBox.Text = player.Country;
            this.PhoneNumberTextBox.Text = player.PhoneNumber;
            this.BirthTextBox.Text = player.Birth.ToShortDateString();
            this.PassportNumberTextBox.Text = player.PassportNumber;
            this.ExpirationDateTextBox.Text = player.ExpirationDate.ToShortDateString();
            this.NationalityTextBox.Text = player.Nationality;
        }

        public ChangeProfile(PlayerModel player, DataBaseWork dataBase)
        {
            InitializeComponent();
            this.player = player;
            this.dataBase = dataBase;
            InitializeCountries();
            InitializeProfile();
        }

        private void InitializeCountries()
        {
            List<CountryModel> countries = this.dataBase.GetCountries();
            this.dictionary = new Dictionary<string, int>();
            foreach (var countryModel in countries)
            {
                this.CountryComboBox.Items.Add(countryModel.Country);
                this.dictionary.Add(countryModel.Country, countryModel.Id);
            }
        }

        private void SaveChangeButton_Click(object sender, EventArgs e)
        {
            if (this.player == null)
            {
                return;
            }
            try
            {
                player.Login = this.LoginTextBox.Text;
                player.Password = this.PasswordTextBox.Text;
                player.FirstName = this.FirstNameTextBox.Text;
                player.Surname = this.SurnameTextBox.Text;
                player.Sex = this.SexComboBox.Text == "Male";
                player.Email = this.EmailTextBox.Text;
                player.CountryId = this.dictionary[this.CountryComboBox.Text];
                player.Country = this.CountryComboBox.Text;
                player.PhoneNumber = this.PhoneNumberTextBox.Text;
                player.Birth = RegistrationModel.Parse(this.BirthTextBox.Text);
                player.PassportNumber = this.PassportNumberTextBox.Text;
                player.ExpirationDate = RegistrationModel.Parse(this.ExpirationDateTextBox.Text);
                player.Nationality = NationalityTextBox.Text;

                this.dataBase.UpdatePlayer(player);
                this.UpdateData.Invoke(player.Id);

                this.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Invalid data format!!!");
            }
        }
    }
}
