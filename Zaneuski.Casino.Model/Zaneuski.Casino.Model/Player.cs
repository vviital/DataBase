namespace Zaneuski.Casino.Model
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Player
    /// </summary>
    public class Player : Person, IInitializer
    {
        /// <summary>
        /// Gets or sets the phone number.
        /// </summary>
        /// <value>
        /// The phone number.
        /// </value>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the account balance.
        /// </summary>
        /// <value>
        /// The account balance.
        /// </value>
        public double AccountBalance { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [verify flag].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [verify flag]; otherwise, <c>false</c>.
        /// </value>
        public bool VerifyFlag { get; set; }

        /// <summary>
        /// Gets or sets the is friends.
        /// </summary>
        /// <value>
        /// The is friends.
        /// </value>
        public virtual List<Player> isFriends { get; set; }

        /// <summary>
        /// Gets or sets the have friends.
        /// </summary>
        /// <value>
        /// The have friends.
        /// </value>
        public virtual List<Player> haveFriends { get; set; }

        /// <summary>
        /// Gets or sets the admin.
        /// </summary>
        /// <value>
        /// The admin.
        /// </value>
        public virtual Administrator Admin { get; set; }

        /// <summary>
        /// Gets or sets the tournaments.
        /// </summary>
        /// <value>
        /// The tournaments.
        /// </value>
        public virtual List<Tournament> Tournaments { get; set; }

        /// <summary>
        /// Gets or sets the passport.
        /// </summary>
        /// <value>
        /// The passport.
        /// </value>
        public virtual PassportInformation Passport { get; set; }

        /// <summary>
        /// Gets or sets the round results.
        /// </summary>
        /// <value>
        /// The round results.
        /// </value>
        public virtual List<RoundResult> RoundResults { get; set; }

        /// <summary>
        /// Gets or sets the country.
        /// </summary>
        /// <value>
        /// The country.
        /// </value>
        public virtual Country Country { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Player"/> class.
        /// </summary>
        public Player()
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Player"/> class.
        /// </summary>
        /// <param name="login">The login.</param>
        /// <param name="password">The password.</param>
        /// <param name="surname">The surname.</param>
        /// <param name="firstname">The firstname.</param>
        /// <param name="sex">if set to <c>true</c> [sex].</param>
        /// <param name="email">The email.</param>
        /// <param name="birth">The birth.</param>
        /// <param name="phoneNumber">The phone number.</param>
        public Player(string login, string password, string surname, string firstname, bool sex, string email,
            DateTime birth, string phoneNumber)
            : base(login, password, surname, firstname, sex, email, birth)
        {
            Initialize();
            this.PhoneNumber = phoneNumber;
            this.AccountBalance = 0;
            this.VerifyFlag = false;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Player"/> class.
        /// </summary>
        /// <param name="login">The login.</param>
        /// <param name="password">The password.</param>
        /// <param name="surname">The surname.</param>
        /// <param name="firstname">The firstname.</param>
        /// <param name="sex">if set to <c>true</c> [sex].</param>
        /// <param name="email">The email.</param>
        /// <param name="birth">The birth.</param>
        /// <param name="country">The country.</param>
        /// <param name="phoneNumber">The phone number.</param>
        /// <param name="passport">The passport.</param>
        /// <param name="accountBalance">The account balance.</param>
        /// <param name="verifyFlag">if set to <c>true</c> [verify flag].</param>
        public Player(string login, string password, string surname, string firstname, bool sex, string email,
            DateTime birth, Country country, string phoneNumber, PassportInformation passport, double accountBalance, bool verifyFlag)
            : base(login, password, surname, firstname, sex, email, birth)
        {
            Initialize();
            this.PhoneNumber = phoneNumber;
            this.AccountBalance = accountBalance;
            this.VerifyFlag = verifyFlag;
        }

        /// <summary>
        /// Initializes this instance.
        /// </summary>
        public void Initialize()
        {
            this.isFriends = new List<Player>();
            this.haveFriends = new List<Player>();
            //isFriends.Add(this);
            //haveFriends.Add(this);
            this.Tournaments = new List<Tournament>();
            this.RoundResults = new List<RoundResult>();
        }
    }
}
