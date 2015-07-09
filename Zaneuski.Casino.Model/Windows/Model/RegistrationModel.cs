using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Windows.Model
{
    public class RegistrationModel
    {
        public string Login { get; set; }

        public string Password { get; set; }

        public string FirstName { get; set; }

        public string Surname { get; set; }

        public string Sex { get; set; }

        public string Email { get; set; }

        public int Country { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime Birth { get; set; }

        public string PassportNumber { get; set; }

        public DateTime ExpirationDate { get; set; }

        public string Nationality { get; set; }

        public static DateTime Parse(string s)
        {
            string[] array = s.Split('.');
            if (array.Count() > 3)
            {
                throw new Exception();
            }
            DateTime date = new DateTime(Int32.Parse(array[2]), Int32.Parse(array[1]), Int32.Parse(array[0]));
            return date;
        }
    }
}
