namespace TestApplication
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TournamentRestriction
    {
        public TournamentRestriction()
        {
            Tournaments = new HashSet<Tournament>();
        }

        public int Id { get; set; }

        public int MinimumNumberOfWins { get; set; }

        public int MaximumNumberOfWins { get; set; }

        public double Fee { get; set; }

        public virtual ICollection<Tournament> Tournaments { get; set; }
    }
}
