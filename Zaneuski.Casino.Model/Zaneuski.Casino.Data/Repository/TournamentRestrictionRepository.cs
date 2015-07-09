namespace Zaneuski.Casino.Data.Repository
{
    using Zaneuski.Casino.Model;
    using Zaneuski.Casino.Model.Repository;

    /// <summary>
    /// TournamentRestriction Repository class
    /// </summary>
    public class TournamentRestrictionRepository : BaseRepository<TournamentRestriction>, ITournamentRestrictionRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TournamentRestrictionRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public TournamentRestrictionRepository(CasinoContext context)
            : base(context)
        {
            
        }
    }
}
