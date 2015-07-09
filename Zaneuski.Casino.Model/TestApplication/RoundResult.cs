namespace TestApplication
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RoundResult
    {
        public int Id { get; set; }

        public double Gain { get; set; }

        public int TournamentRoom_Id { get; set; }

        public int Participant_Id { get; set; }

        public virtual Player Player { get; set; }

        public virtual Round Round { get; set; }
    }
}
