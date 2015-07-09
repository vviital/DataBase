namespace Zaneuski.Casino.Data.Configuration
{
    using System.Data.Entity.ModelConfiguration;
    using Zaneuski.Casino.Model;

    /// <summary>
    /// RoundResult Configuration class
    /// </summary>
    public class RoundResultConfiguration : EntityTypeConfiguration<RoundResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoundResultConfiguration"/> class.
        /// </summary>
        public RoundResultConfiguration()
        {
            HasKey(o => o.Id).Property(o => o.Id);

            Property(o => o.Gain).IsRequired();
        }
    }
}
