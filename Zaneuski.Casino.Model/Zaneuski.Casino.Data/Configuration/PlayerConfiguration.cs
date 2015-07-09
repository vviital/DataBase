namespace Zaneuski.Casino.Data.Configuration
{
    using System.Data.Entity.ModelConfiguration;
    using Zaneuski.Casino.Model;

    /// <summary>
    /// Player Configuration class
    /// </summary>
    public class PlayerConfiguration : EntityTypeConfiguration<Player>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerConfiguration"/> class.
        /// </summary>
        public PlayerConfiguration()
        {
            HasKey(o => o.Id).Property(o => o.Id);

            Property(o => o.Login).IsRequired().HasMaxLength(30);

            Property(o => o.Password).IsRequired().HasMaxLength(30);

            Property(o => o.Surname).IsRequired().HasMaxLength(50);

            Property(o => o.FirstName).IsRequired().HasMaxLength(50);

            Property(o => o.Birth).IsRequired();

            Property(o => o.Email).IsRequired().HasMaxLength(50);

            Property(o => o.Sex).IsRequired();

            Property(o => o.PhoneNumber).IsRequired().HasMaxLength(50);

            Property(o => o.VerifyFlag).IsRequired();

            Property(o => o.AccountBalance).IsRequired();

            HasMany(o => o.Tournaments).WithMany(s => s.Participants);

            HasMany(o => o.haveFriends).WithMany(s => s.isFriends);

            HasMany(o => o.RoundResults).WithRequired(s => s.Participant).WillCascadeOnDelete(false);
            
            HasRequired(o => o.Passport).WithRequiredDependent(s => s.Player).WillCascadeOnDelete(false);
        }
    }
}
