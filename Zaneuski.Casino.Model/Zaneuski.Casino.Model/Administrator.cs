namespace Zaneuski.Casino.Model
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Administrator class
    /// </summary>
    public class Administrator : Person, IInitializer
    {
        /// <summary>
        /// Gets or sets the observed players.
        /// </summary>
        /// <value>
        /// The observed players.
        /// </value>
        public virtual List<Player> ObservedPlayers { get; set; }

        /// <summary>
        /// Gets or sets the supervised tournaments.
        /// </summary>
        /// <value>
        /// The supervised tournaments.
        /// </value>
        public virtual List<Tournament> SupervisedTournaments { get; set; }

        /// <summary>
        /// Gets or sets the country.
        /// </summary>
        /// <value>
        /// The country.
        /// </value>
        public virtual Country Country { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Administrator"/> class.
        /// </summary>
        public Administrator()
            : base()
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Administrator"/> class.
        /// </summary>
        /// <param name="login">The login.</param>
        /// <param name="password">The password.</param>
        /// <param name="surname">The surname.</param>
        /// <param name="firstname">The firstname.</param>
        /// <param name="sex">if set to <c>true</c> [sex].</param>
        /// <param name="email">The email.</param>
        /// <param name="birth">The birth.</param>
        /// <param name="homeCountry">The home country.</param>
        public Administrator(string login, string password, string surname, string firstname, bool sex, string email,
            DateTime birth, Country homeCountry)
            : base(login, password, surname, firstname, sex, email, birth)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes this instance.
        /// </summary>
        public void Initialize()
        {
            this.ObservedPlayers = new List<Player>();
            this.SupervisedTournaments = new List<Tournament>();
        }
    }
}
