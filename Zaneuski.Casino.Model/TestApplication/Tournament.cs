namespace TestApplication
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tournament
    {
        public Tournament()
        {
            Rounds = new HashSet<Round>();
            Players = new HashSet<Player>();
        }

        public int Id { get; set; }

        [Required]
        public string TournamentName { get; set; }

        public DateTime Schedule { get; set; }

        public int GameType_Id { get; set; }

        public int Restriction_Id { get; set; }

        public int Admin_Id { get; set; }

        public virtual Administrator Administrator { get; set; }

        public virtual GameType GameType { get; set; }

        public virtual ICollection<Round> Rounds { get; set; }

        public virtual TournamentRestriction TournamentRestriction { get; set; }

        public virtual ICollection<Player> Players { get; set; }
    }
}
