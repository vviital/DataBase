namespace TestApplication
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Administrator
    {
        public Administrator()
        {
            Players = new HashSet<Player>();
            Tournaments = new HashSet<Tournament>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Login { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        [Required]
        [StringLength(50)]
        public string Surname { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        public bool Sex { get; set; }

        [Required]
        public string Email { get; set; }

        public DateTime Birth { get; set; }

        public int Country_Id { get; set; }

        public virtual Country Country { get; set; }

        public virtual ICollection<Player> Players { get; set; }

        public virtual ICollection<Tournament> Tournaments { get; set; }
    }
}
