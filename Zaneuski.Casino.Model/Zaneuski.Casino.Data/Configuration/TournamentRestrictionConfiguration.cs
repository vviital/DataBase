namespace Zaneuski.Casino.Data.Configuration
{
    using System.Data.Entity.ModelConfiguration;
    using Zaneuski.Casino.Model;

    /// <summary>
    /// TournamentRestriction Configuration class
    /// </summary>
    public class TournamentRestrictionConfiguration : EntityTypeConfiguration<TournamentRestriction>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TournamentRestrictionConfiguration"/> class.
        /// </summary>
        public TournamentRestrictionConfiguration()
        {
            HasKey(o => o.Id).Property(o => o.Id);

            HasMany(o => o.Tournaments).WithRequired(s => s.Restriction).WillCascadeOnDelete(false);

            Property(o => o.Fee).IsRequired();

            Property(o => o.MinimumNumberOfWins).IsRequired();
        }
    }
}
