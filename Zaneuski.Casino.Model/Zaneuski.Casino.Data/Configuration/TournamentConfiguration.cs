namespace Zaneuski.Casino.Data.Configuration
{
    using System.Data.Entity.ModelConfiguration;
    using Zaneuski.Casino.Model;

    /// <summary>
    /// Tournament Configuration class
    /// </summary>
    class TournamentConfiguration : EntityTypeConfiguration<Tournament>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TournamentConfiguration"/> class.
        /// </summary>
        public TournamentConfiguration()
        {
            HasKey(o => o.Id).Property(o => o.Id);

            HasMany(o => o.Rounds).WithRequired(s => s.Tournament).WillCascadeOnDelete(false);

            Property(o => o.Schedule).IsRequired();

            Property(o => o.TournamentName).IsRequired();
        }
    }
}
