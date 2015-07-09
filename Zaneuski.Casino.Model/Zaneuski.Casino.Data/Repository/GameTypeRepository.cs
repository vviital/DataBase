namespace Zaneuski.Casino.Data.Repository
{
    using Zaneuski.Casino.Model;
    using Zaneuski.Casino.Model.Repository;

    /// <summary>
    /// GameType Repository class
    /// </summary>
    public class GameTypeRepository : BaseRepository<GameType>, IGameTypeRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GameTypeRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public GameTypeRepository(CasinoContext context)
            :   base(context)
        {
            
        }
    }
}
