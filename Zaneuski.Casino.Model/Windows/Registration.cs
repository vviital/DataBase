using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.DataBaseMethod;
using Windows.Model;

namespace Windows
{
    public partial class Registration : Form
    {
        private Dictionary<string, int> dictionary;

        private DataBaseWork dataBase;

        public Registration()
        {
            InitializeComponent();
            PasswordTextBox.PasswordChar = '*';
        }

        public Registration(DataBaseWork dataBase)
        {
            InitializeComponent();
            this.dataBase = dataBase;
            InitializeCountries();
            SexComboBox.Text = SexComboBox.Items[0].ToString();
            CountryComboBox.Text = CountryComboBox.Items[0].ToString();
        }

        private void Check(string source)
        {
            if (string.IsNullOrEmpty(source)) throw new Exception();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            try
            {
                PlayerModel player = new PlayerModel();
                player.Login = LoginTextBox.Text;
                player.Password = PasswordTextBox.Text;
                player.FirstName = FirstNameTextBox.Text;
                player.Surname = SurnameTextBox.Text;
                player.Sex = SexComboBox.Text == "Male";
                player.Email = EmailTextBox.Text;
                player.Country = CountryComboBox.Text;
                player.CountryId = this.dictionary[CountryComboBox.Text];
                player.PhoneNumber = this.PhoneNumberTextBox.Text;
                player.Birth = RegistrationModel.Parse(this.BirthTextBox.Text);
                player.PassportNumber = PasswordTextBox.Text;
                player.ExpirationDate = RegistrationModel.Parse(ExpirationDateTextBox.Text);
                player.Nationality = NationalityTextBox.Text;

                this.dataBase.InsertPlayer(player);

                this.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Invalid data format!!!");
            }
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
    }
}
