namespace Zaneuski.Casino.Model
{
    using System.Collections.Generic;

    /// <summary>
    /// Round class
    /// </summary>
    public class Round : BaseUnit, IInitializer
    {
        /// <summary>
        /// Gets or sets the room number.
        /// </summary>
        /// <value>
        /// The room number.
        /// </value>
        public int RoomNumber { get; set; }

        /// <summary>
        /// Gets or sets the round results.
        /// </summary>
        /// <value>
        /// The round results.
        /// </value>
        public virtual List<RoundResult> RoundResults { get; set; }

        /// <summary>
        /// Gets or sets the tournament.
        /// </summary>
        /// <value>
        /// The tournament.
        /// </value>
        public virtual Tournament Tournament { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Round"/> class.
        /// </summary>
        public Round()
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Round"/> class.
        /// </summary>
        /// <param name="roomNumber">The room number.</param>
        public Round(int roomNumber)
        {
            Initialize();
            this.RoomNumber = roomNumber;
        }

        /// <summary>
        /// Initializes this instance.
        /// </summary>
        public void Initialize()
        {
            this.RoundResults = new List<RoundResult>();
        }
    }
}
