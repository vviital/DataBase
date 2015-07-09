namespace TestApplication
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Player
    {
        public Player()
        {
            RoundResults = new HashSet<RoundResult>();
            Players1 = new HashSet<Player>();
            Players = new HashSet<Player>();
            Tournaments = new HashSet<Tournament>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string PhoneNumber { get; set; }

        public double AccountBalance { get; set; }

        public bool VerifyFlag { get; set; }

        [Required]
        [StringLength(30)]
        public string Login { get; set; }

        [Required]
        [StringLength(30)]
        public string Password { get; set; }

        [Required]
        [StringLength(50)]
        public string Surname { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        public bool Sex { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        public DateTime Birth { get; set; }

        public int Country_Id { get; set; }

        public int Admin_Id { get; set; }

        public virtual Administrator Administrator { get; set; }

        public virtual Country Country { get; set; }

        public virtual PassportInformation PassportInformation { get; set; }

        public virtual ICollection<RoundResult> RoundResults { get; set; }

        public virtual ICollection<Player> Players1 { get; set; }

        public virtual ICollection<Player> Players { get; set; }

        public virtual ICollection<Tournament> Tournaments { get; set; }
    }
}
