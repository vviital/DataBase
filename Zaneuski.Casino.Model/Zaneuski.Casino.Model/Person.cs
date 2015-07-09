namespace Zaneuski.Casino.Model
{
    using System;

    /// <summary>
    /// Person class
    /// </summary>
    public class Person : BaseUnit
    {
        /// <summary>
        /// Gets or sets the login.
        /// </summary>
        /// <value>
        /// The login.
        /// </value>
        public string Login { get; set; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>
        /// The password.
        /// </value>
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets the surname.
        /// </summary>
        /// <value>
        /// The surname.
        /// </value>
        public string Surname { get; set; }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Person"/> is sex.
        /// </summary>
        /// <value>
        ///   <c>true</c> if sex; otherwise, <c>false</c>.
        /// </value>
        public bool Sex { get; set; }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the birth.
        /// </summary>
        /// <value>
        /// The birth.
        /// </value>
        public DateTime Birth { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class.
        /// </summary>
        public Person()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class.
        /// </summary>
        /// <param name="login">The login.</param>
        /// <param name="password">The password.</param>
        /// <param name="surname">The surname.</param>
        /// <param name="firstname">The firstname.</param>
        /// <param name="sex">if set to <c>true</c> [sex].</param>
        /// <param name="email">The email.</param>
        /// <param name="birth">The birth.</param>
        public Person(string login, string password, string surname, string firstname, bool sex, string email,
            DateTime birth)
        {
            this.Login = login;
            this.Password = password;
            this.Surname = surname;
            this.FirstName = firstname;
            this.Sex = sex;
            this.Email = email;
            this.Birth = birth;
        }
    }
}
