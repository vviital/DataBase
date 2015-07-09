namespace Zaneuski.Casino.Data.Repository
{
    using Zaneuski.Casino.Model;
    using Zaneuski.Casino.Model.Repository;

    /// <summary>
    /// PassportInformation Repository class
    /// </summary>
    public class PassportInformationRepository : BaseRepository<PassportInformation>, IPassportInformationRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PassportInformationRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public PassportInformationRepository(CasinoContext context) 
            : base(context)
        {
            
        }
    }
}
