namespace Zaneuski.Casino.Data.Configuration
{
    using System.Data.Entity.ModelConfiguration;
    using Zaneuski.Casino.Model;

    /// <summary>
    /// GameType Configuration class
    /// </summary>
    public class GameTypeConfiguration : EntityTypeConfiguration<GameType>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GameTypeConfiguration"/> class.
        /// </summary>
        public GameTypeConfiguration()
        {
            HasKey(o => o.Id).Property(o => o.Id);

            Property(o => o.Type).IsRequired().HasMaxLength(50);

            HasMany(o => o.Tournaments).WithRequired(s => s.GameType).WillCascadeOnDelete(false);
        }
    }
}
