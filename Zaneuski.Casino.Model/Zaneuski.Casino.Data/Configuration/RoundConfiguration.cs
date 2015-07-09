namespace Zaneuski.Casino.Data.Configuration
{
    using System.Data.Entity.ModelConfiguration;
    using Zaneuski.Casino.Model;

    /// <summary>
    /// Round Configuration
    /// </summary>
    public class RoundConfiguration : EntityTypeConfiguration<Round>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoundConfiguration"/> class.
        /// </summary>
        public RoundConfiguration()
        {
            HasKey(o => o.Id).Property(o => o.Id);

            Property(o => o.RoomNumber).IsRequired();

            HasMany(o => o.RoundResults).WithRequired(s => s.TournamentRoom).WillCascadeOnDelete(false);
        }
    }
}
