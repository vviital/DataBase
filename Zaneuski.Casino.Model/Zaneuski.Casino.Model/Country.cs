namespace Zaneuski.Casino.Model
{
    using System.Collections.Generic;

    /// <summary>
    /// Country class
    /// </summary>
    public class Country : BaseUnit, IInitializer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Country"/> class.
        /// </summary>
        public Country()
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Country"/> class.
        /// </summary>
        /// <param name="country">The country.</param>
        public Country(string country)
        {
            Initialize();
            this.CountryName = country;
        }

        /// <summary>
        /// Initializes this instance.
        /// </summary>
        public void Initialize()
        {
            this.Administrators = new List<Administrator>();
            this.Players = new List<Player>();
        }

        /// <summary>
        /// Gets or sets the name of the country.
        /// </summary>
        /// <value>
        /// The name of the country.
        /// </value>
        public string CountryName { get; set; }

        /// <summary>
        /// Gets or sets the players.
        /// </summary>
        /// <value>
        /// The players.
        /// </value>
        public virtual List<Player> Players { get; set; }

        /// <summary>
        /// Gets or sets the administrators.
        /// </summary>
        /// <value>
        /// The administrators.
        /// </value>
        public virtual List<Administrator> Administrators { get; set; } 
    }
}
