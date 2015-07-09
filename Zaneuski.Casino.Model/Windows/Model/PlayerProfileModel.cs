using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows.Model
{
    public class PlayerProfileModel
    {
        public string Login { get; set; }

        public string FirstName { get; set; }

        public string Surname { get; set; }

        public bool Sex { get; set; }

        public string Email { get; set; }

        public string Country { get; set; }

        public bool IsFriend { get; set; }
    }
}
