namespace TestApplication
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PassportInformation
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string PassportNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string Nationality { get; set; }

        public DateTime ExpirationDate { get; set; }

        public virtual Player Player { get; set; }
    }
}
