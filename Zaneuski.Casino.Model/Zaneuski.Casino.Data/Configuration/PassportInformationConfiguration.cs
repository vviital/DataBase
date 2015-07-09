namespace Zaneuski.Casino.Data.Configuration
{
    using System.Data.Entity.ModelConfiguration;
    using Zaneuski.Casino.Model;

    /// <summary>
    /// PassportInformation Configuration class
    /// </summary>
    public class PassportInformationConfiguration : EntityTypeConfiguration<PassportInformation>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PassportInformationConfiguration"/> class.
        /// </summary>
        public PassportInformationConfiguration()
        {
            HasKey(o => o.Id).Property(o => o.Id);

            Property(o => o.Nationality).IsRequired().HasMaxLength(50);

            Property(o => o.PassportNumber).IsRequired().HasMaxLength(50);

            Property(o => o.ExpirationDate).IsRequired();
        }
    }
}
