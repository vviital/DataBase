namespace TestApplication
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Round
    {
        public Round()
        {
            RoundResults = new HashSet<RoundResult>();
        }

        public int Id { get; set; }

        public int RoomNumber { get; set; }

        public int Tournament_Id { get; set; }

        public virtual ICollection<RoundResult> RoundResults { get; set; }

        public virtual Tournament Tournament { get; set; }
    }
}
