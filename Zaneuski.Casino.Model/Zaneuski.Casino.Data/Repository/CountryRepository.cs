namespace Zaneuski.Casino.Data.Repository
{
    using Zaneuski.Casino.Model;
    using Zaneuski.Casino.Model.Repository;

    /// <summary>
    /// Country Repository class
    /// </summary>
    public class CountryRepository : BaseRepository<Country>, ICountryRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CountryRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public CountryRepository(CasinoContext context)
            : base(context)
        {
            
        }
    }
}
