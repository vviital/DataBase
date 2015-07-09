namespace Zaneuski.Casino.Data.Configuration
{
    using System.Data.Entity.ModelConfiguration;
    using Zaneuski.Casino.Model;

    /// <summary>
    /// Administrator Configuration class
    /// </summary>
    public class AdministratorConfiguration : EntityTypeConfiguration<Administrator>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdministratorConfiguration"/> class.
        /// </summary>
        public AdministratorConfiguration()
        {
            HasKey(o => o.Id).Property(o => o.Id);

            Property(o => o.Birth).IsRequired();

            Property(o => o.Login).IsRequired().HasMaxLength(50);

            Property(o => o.Password).IsRequired().HasMaxLength(50);

            Property(o => o.Sex).IsRequired();

            Property(o => o.Surname).IsRequired().HasMaxLength(50);

            Property(o => o.FirstName).IsRequired().HasMaxLength(50);

            Property(o => o.Email).IsRequired();

            HasMany(o => o.ObservedPlayers).WithRequired(s => s.Admin).WillCascadeOnDelete(false);

            HasMany(o => o.SupervisedTournaments).WithRequired(s => s.Admin).WillCascadeOnDelete(false);
        }
    }
}
