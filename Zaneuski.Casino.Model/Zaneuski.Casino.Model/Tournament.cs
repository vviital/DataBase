namespace Zaneuski.Casino.Model
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Tournament class
    /// </summary>
    public class Tournament : BaseUnit, IInitializer
    {
        /// <summary>
        /// Gets or sets the type of the game.
        /// </summary>
        /// <value>
        /// The type of the game.
        /// </value>
        public virtual GameType GameType { get; set; }

        /// <summary>
        /// Gets or sets the participants.
        /// </summary>
        /// <value>
        /// The participants.
        /// </value>
        public virtual List<Player> Participants { get; set; }

        /// <summary>
        /// Gets or sets the admin.
        /// </summary>
        /// <value>
        /// The admin.
        /// </value>
        public virtual Administrator Admin { get; set; }

        /// <summary>
        /// Gets or sets the restriction.
        /// </summary>
        /// <value>
        /// The restriction.
        /// </value>
        public virtual TournamentRestriction Restriction { get; set; }

        /// <summary>
        /// Gets or sets the name of the tournament.
        /// </summary>
        /// <value>
        /// The name of the tournament.
        /// </value>
        public string TournamentName { get; set; }

        /// <summary>
        /// Gets or sets the schedule.
        /// </summary>
        /// <value>
        /// The schedule.
        /// </value>
        public DateTime Schedule { get; set; }

        /// <summary>
        /// Gets or sets the rounds.
        /// </summary>
        /// <value>
        /// The rounds.
        /// </value>
        public virtual List<Round> Rounds { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Tournament"/> class.
        /// </summary>
        public Tournament()
        {
            Initialize();
        }

        /// <summary>
        /// Initializes this instance.
        /// </summary>
        public void Initialize()
        {
            this.Participants = new List<Player>();
            this.Rounds = new List<Round>();
        }
    }
}
