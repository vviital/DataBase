namespace Zaneuski.Casino.Data.Configuration
{
    using System.Data.Entity.ModelConfiguration;
    using Zaneuski.Casino.Model;

    /// <summary>
    /// Country Configuration class
    /// </summary>
    public class CountryConfiguration : EntityTypeConfiguration<Country>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CountryConfiguration"/> class.
        /// </summary>
        public CountryConfiguration()
        {
            HasKey(o => o.Id).Property(o => o.Id);

            HasMany(o => o.Players).WithRequired(s => s.Country).WillCascadeOnDelete(false);//.HasForeignKey(p => p.CountryId);

            HasMany(o => o.Administrators).WithRequired(s => s.Country).WillCascadeOnDelete(false);

            Property(o => o.CountryName).IsRequired().HasMaxLength(50);
        }
    }
}
