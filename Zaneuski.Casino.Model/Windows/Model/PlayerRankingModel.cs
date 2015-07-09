using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows.Model
{
    public class PlayerRankingModel
    {
        public int Id { get; set; }

        public string Login { get; set; }

        public string FirstName { get; set; }

        public string Surname { get; set; }

        public double TotalGain { get; set; }
    }
}
