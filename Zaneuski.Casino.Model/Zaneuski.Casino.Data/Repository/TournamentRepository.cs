namespace Zaneuski.Casino.Data.Repository
{
    using Zaneuski.Casino.Model;
    using Zaneuski.Casino.Model.Repository;

    /// <summary>
    /// Tournament Repository class
    /// </summary>
    public class TournamentRepository : BaseRepository<Tournament>, ITournamentRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TournamentRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public TournamentRepository(CasinoContext context)
            : base(context)
        {
            
        }
    }
}
