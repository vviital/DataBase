namespace Zaneuski.Casino.Model
{
    /// <summary>
    /// Round Result class
    /// </summary>
    public class RoundResult : BaseUnit
    {
        /// <summary>
        /// Gets or sets the tournament room.
        /// </summary>
        /// <value>
        /// The tournament room.
        /// </value>
        public virtual Round TournamentRoom { get; set; }

        /// <summary>
        /// Gets or sets the participant.
        /// </summary>
        /// <value>
        /// The participant.
        /// </value>
        public virtual Player Participant { get; set; }

        /// <summary>
        /// Gets or sets the gain.
        /// </summary>
        /// <value>
        /// The gain.
        /// </value>
        public double Gain { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="RoundResult"/> class.
        /// </summary>
        public RoundResult()
        {

        }
    }
}
