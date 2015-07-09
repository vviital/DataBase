namespace Zaneuski.Casino.Model
{
    using System.Collections.Generic;

    /// <summary>
    /// TournamentRestriction class
    /// </summary>
    public class TournamentRestriction : BaseUnit, IInitializer
    {
        /// <summary>
        /// Gets or sets the minimum number of wins.
        /// </summary>
        /// <value>
        /// The minimum number of wins.
        /// </value>
        public int MinimumNumberOfWins { get; set; }

        /// <summary>
        /// Gets or sets the maximum number of wins.
        /// </summary>
        /// <value>
        /// The maximum number of wins.
        /// </value>
        public int MaximumNumberOfWins { get; set; }

        /// <summary>
        /// Gets or sets the fee.
        /// </summary>
        /// <value>
        /// The fee.
        /// </value>
        public double Fee { get; set; }

        /// <summary>
        /// Gets or sets the tournaments.
        /// </summary>
        /// <value>
        /// The tournaments.
        /// </value>
        public virtual List<Tournament> Tournaments { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TournamentRestriction"/> class.
        /// </summary>
        public TournamentRestriction()
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TournamentRestriction"/> class.
        /// </summary>
        /// <param name="typeCode">The type code.</param>
        /// <param name="minimumNumberOfWins">The minimum number of wins.</param>
        /// <param name="maximumNumberOfWins">The maximum number of wins.</param>
        /// <param name="fee">The fee.</param>
        public TournamentRestriction(string typeCode, int minimumNumberOfWins, int maximumNumberOfWins, double fee)
        {
            Initialize();
            this.MinimumNumberOfWins = minimumNumberOfWins;
            this.MaximumNumberOfWins = maximumNumberOfWins;
            this.Fee = fee;
        }

        /// <summary>
        /// Initializes this instance.
        /// </summary>
        public void Initialize()
        {
            this.Tournaments = new List<Tournament>();
        }
    }
}
