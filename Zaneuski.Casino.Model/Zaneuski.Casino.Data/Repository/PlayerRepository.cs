namespace Zaneuski.Casino.Data.Repository
{
    using Zaneuski.Casino.Model;
    using Zaneuski.Casino.Model.Repository;

    /// <summary>
    /// Player Repository class
    /// </summary>
    public class PlayerRepository : BaseRepository<Player>, IPlayerRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public PlayerRepository(CasinoContext context)
            : base(context)
        {
            
        }
    }
}
