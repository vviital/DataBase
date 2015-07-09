namespace Zaneuski.Casino.Model
{
    using System.Collections.Generic;

    /// <summary>
    /// GameType class
    /// </summary>
    public class GameType : BaseUnit, IInitializer
    {
        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the tournaments.
        /// </summary>
        /// <value>
        /// The tournaments.
        /// </value>
        public virtual List<Tournament> Tournaments { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameType"/> class.
        /// </summary>
        public GameType()
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameType"/> class.
        /// </summary>
        /// <param name="type">The type.</param>
        public GameType(string type)
        {
            Initialize();
            this.Type = type;
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
