namespace Zaneuski.Casino.Model
{
    using System;

    /// <summary>
    /// PassportInformation class
    /// </summary>
    public class PassportInformation : BaseUnit
    {
        /// <summary>
        /// Gets or sets the passport number.
        /// </summary>
        /// <value>
        /// The passport number.
        /// </value>
        public string PassportNumber { get; set; }

        /// <summary>
        /// Gets or sets the nationality.
        /// </summary>
        /// <value>
        /// The nationality.
        /// </value>
        public string Nationality { get; set; }

        /// <summary>
        /// Gets or sets the expiration date.
        /// </summary>
        /// <value>
        /// The expiration date.
        /// </value>
        public DateTime ExpirationDate { get; set; }

        /// <summary>
        /// Gets or sets the player.
        /// </summary>
        /// <value>
        /// The player.
        /// </value>
        public virtual Player Player { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PassportInformation"/> class.
        /// </summary>
        public PassportInformation()
        {
            
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PassportInformation"/> class.
        /// </summary>
        /// <param name="passportNumber">The passport number.</param>
        /// <param name="nationality">The nationality.</param>
        /// <param name="expirationDate">The expiration date.</param>
        public PassportInformation(string passportNumber, string nationality, DateTime expirationDate)
        {
            this.PassportNumber = passportNumber;
            this.Nationality = nationality;
            this.ExpirationDate = expirationDate;
        }
    }
}
