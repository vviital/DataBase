using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows.Model
{
    public class TournamentInfoModel
    {
        public TournamentModel Tournament { get; set; }

        public List<RoundModel> Rounds { get; set; } 
    }
}
