using System.ComponentModel.DataAnnotations.Schema;

namespace Zaneuski.Casino.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration;
    using System.Linq;
    using Zaneuski.Casino.Model;

    /// <summary>
    /// CasinoContext
    /// </summary>
    public class CasinoContext : DbContext
    {
        /// <summary>
        /// Gets or sets the players.
        /// </summary>
        /// <value>
        /// The players.
        /// </value>
        public DbSet<Player> Players { get; set; }

        /// <summary>
        /// Gets or sets the administrators.
        /// </summary>
        /// <value>
        /// The administrators.
        /// </value>
        public DbSet<Administrator> Administrators { get; set; }

        /// <summary>
        /// Gets or sets the tournaments.
        /// </summary>
        /// <value>
        /// The tournaments.
        /// </value>
        public DbSet<Tournament> Tournaments { get; set; }

        /// <summary>
        /// Gets or sets the rounds.
        /// </summary>
        /// <value>
        /// The rounds.
        /// </value>
        public DbSet<Round> Rounds { get; set; }

        /// <summary>
        /// Gets or sets the round results.
        /// </summary>
        /// <value>
        /// The round results.
        /// </value>
        public DbSet<RoundResult> RoundResults { get; set; }

        /// <summary>
        /// Gets or sets the passport informations.
        /// </summary>
        /// <value>
        /// The passport informations.
        /// </value>
        public DbSet<PassportInformation> PassportInformations { get; set; }

        /// <summary>
        /// Gets or sets the countries.
        /// </summary>
        /// <value>
        /// The countries.
        /// </value>
        public DbSet<Country> Countries { get; set; }

        /// <summary>
        /// Gets or sets the tournament restrictions.
        /// </summary>
        /// <value>
        /// The tournament restrictions.
        /// </value>
        public DbSet<TournamentRestriction> TournamentRestrictions { get; set; }

        /// <summary>
        /// Gets or sets the game types.
        /// </summary>
        /// <value>
        /// The game types.
        /// </value>
        public DbSet<GameType> GameTypes { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CasinoContext"/> class.
        /// </summary>
        public CasinoContext()
            :base("connectionString")
        {
        }

        /// <summary>
        /// This method is called when the model for a derived context has been initialized, but
        /// before the model has been locked down and used to initialize the context.  The default
        /// implementation of this method does nothing, but it can be overridden in a derived class
        /// such that the model can be further configured before it is locked down.
        /// </summary>
        /// <param name="modelBuilder">The builder that defines the model for the context being created.</param>
        /// <remarks>
        /// Typically, this method is called only once when the first instance of a derived context
        /// is created.  The model for that context is then cached and is for all further instances of
        /// the context in the app domain.  This caching can be disabled by setting the ModelCaching
        /// property on the given ModelBuidler, but note that this can seriously degrade performance.
        /// More control over caching is provided through use of the DbModelBuilder and DbContextFactory
        /// classes directly.
        /// </remarks>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Type[] types = GetType().
                Assembly.GetTypes().Where(x => x.BaseType != null && x.BaseType.IsGenericType && x.BaseType.GetGenericTypeDefinition() == typeof(EntityTypeConfiguration<>)).ToArray();//.
                   // Where(x => x.BaseType != null && x.BaseType.GetGenericTypeDefinition() == typeof(EntityTypeConfiguration<>)).ToArray();
            foreach (var type in types)
            {
                dynamic obj = Activator.CreateInstance(type);
                modelBuilder.Configurations.Add(obj);
            }
            base.OnModelCreating(modelBuilder);
        }
    }
}
