namespace TestApplication
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Administrator> Administrators { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<GameType> GameTypes { get; set; }
        public virtual DbSet<PassportInformation> PassportInformations { get; set; }
        public virtual DbSet<Player> Players { get; set; }
        public virtual DbSet<RoundResult> RoundResults { get; set; }
        public virtual DbSet<Round> Rounds { get; set; }
        public virtual DbSet<TournamentRestriction> TournamentRestrictions { get; set; }
        public virtual DbSet<Tournament> Tournaments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Administrator>()
                .HasMany(e => e.Players)
                .WithRequired(e => e.Administrator)
                .HasForeignKey(e => e.Admin_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Administrator>()
                .HasMany(e => e.Tournaments)
                .WithRequired(e => e.Administrator)
                .HasForeignKey(e => e.Admin_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.Administrators)
                .WithRequired(e => e.Country)
                .HasForeignKey(e => e.Country_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.Players)
                .WithRequired(e => e.Country)
                .HasForeignKey(e => e.Country_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GameType>()
                .HasMany(e => e.Tournaments)
                .WithRequired(e => e.GameType)
                .HasForeignKey(e => e.GameType_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PassportInformation>()
                .HasOptional(e => e.Player)
                .WithRequired(e => e.PassportInformation);

            modelBuilder.Entity<Player>()
                .HasMany(e => e.RoundResults)
                .WithRequired(e => e.Player)
                .HasForeignKey(e => e.Participant_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Player>()
                .HasMany(e => e.Players1)
                .WithMany(e => e.Players)
                .Map(m => m.ToTable("PlayerPlayers").MapRightKey("Player_Id1"));

            modelBuilder.Entity<Player>()
                .HasMany(e => e.Tournaments)
                .WithMany(e => e.Players)
                .Map(m => m.ToTable("PlayerTournaments"));

            modelBuilder.Entity<Round>()
                .HasMany(e => e.RoundResults)
                .WithRequired(e => e.Round)
                .HasForeignKey(e => e.TournamentRoom_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TournamentRestriction>()
                .HasMany(e => e.Tournaments)
                .WithRequired(e => e.TournamentRestriction)
                .HasForeignKey(e => e.Restriction_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tournament>()
                .HasMany(e => e.Rounds)
                .WithRequired(e => e.Tournament)
                .HasForeignKey(e => e.Tournament_Id)
                .WillCascadeOnDelete(false);
        }
    }
}
