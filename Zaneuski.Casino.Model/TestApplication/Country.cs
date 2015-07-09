namespace TestApplication
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Country
    {
        public Country()
        {
            Administrators = new HashSet<Administrator>();
            Players = new HashSet<Player>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string CountryName { get; set; }

        public virtual ICollection<Administrator> Administrators { get; set; }

        public virtual ICollection<Player> Players { get; set; }
    }
}
