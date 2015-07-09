namespace Zaneuski.Casino.Data.Repository
{
    using Zaneuski.Casino.Model;
    using Zaneuski.Casino.Model.Repository;

    /// <summary>
    /// RoundResult Repository class
    /// </summary>
    public class RoundResultRepository : BaseRepository<RoundResult>, IRoundResultRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoundResultRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public RoundResultRepository(CasinoContext context)
            : base(context)
        {
            
        }
    }
}
