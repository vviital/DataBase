namespace Zaneuski.Casino.Data.Repository
{
    using Zaneuski.Casino.Model;
    using Zaneuski.Casino.Model.Repository;

    /// <summary>
    /// Administrator Repository class
    /// </summary>
    public class AdministratorRepository : BaseRepository<Administrator>, IAdministratorRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdministratorRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public AdministratorRepository(CasinoContext context)
            : base(context)
        {
            
        }
    }
}
