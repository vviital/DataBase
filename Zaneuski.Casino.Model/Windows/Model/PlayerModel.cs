using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows.Model
{
    public class PlayerModel
    {
        public int Id { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public string FirstName { get; set; }

        public string Surname { get; set; }

        public bool Sex { get; set; }

        public string Email { get; set; }

        public int CountryId { get; set; }

        public string Country { get; set; }

        public string PhoneNumber { get; set; }
        
        public DateTime Birth { get; set; }

        public int PassportId { get; set; }

        public string PassportNumber { get; set; }

        public DateTime ExpirationDate { get; set; }

        public string Nationality { get; set; }

        public int AdminId { get; set; }

        public string Admin { get; set; }
    }
}
