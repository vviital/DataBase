namespace Zaneuski.Casino.Data.Repository
{
    using Zaneuski.Casino.Model;
    using Zaneuski.Casino.Model.Repository;

    /// <summary>
    /// Round Repository class
    /// </summary>
    public class RoundRepository : BaseRepository<Round>, IRoundRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoundRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public RoundRepository(CasinoContext context)
            : base(context)
        {
            
        }
    }
}
