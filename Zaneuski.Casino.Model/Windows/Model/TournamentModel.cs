using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows.Model
{
    public class TournamentModel
    {
        //
        public int Id { get; set; }

        //
        public string TournamentName { get; set; }

        //
        public DateTime Schedule { get; set; }

        //
        public int Rounds { get; set; }

        //
        public int AdminId { get; set; }

        //
        public string Admin { get; set; }

        public int Participants { get; set; }

        //
        public int GameTypeId { get; set; }

        //
        public string GameType { get; set; }

        //
        public int RestrictionId { get; set; }

        //
        public int Wins { get; set; }

        //
        public double Fee { get; set; }

        public int IsRegistrate { get; set; }
    }
}
