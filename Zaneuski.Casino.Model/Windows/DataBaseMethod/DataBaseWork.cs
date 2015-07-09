using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Windows.Model;
using Microsoft.SqlServer.Server;
using Zaneuski.Casino.Data;
using Zaneuski.Casino.Model;

namespace Windows.DataBaseMethod
{
    public class DataBaseWork
    {
        CasinoContext context;

        public DataBaseWork()
        {
            context = new CasinoContext();
        }

        public void JoinFriend(PlayerModel player, PlayerModel playerFriend)
        {
            if (IsFriend(player, playerFriend))
            {
                throw new Exception();
            }
            string query = string.Format("INSERT INTO PlayerPlayers " +
                                         "(Player_Id, Player_Id1) " +
                                         "VALUES (@ID1, @ID2)");

            int number = this.context.Database.ExecuteSqlCommand(query,
                new SqlParameter("@ID1", player.Id),
                new SqlParameter("@ID2", playerFriend.Id));


        }

        public void UnJoinFriend(PlayerModel player, PlayerModel playerFriend)
        {
            if (IsFriend(player, playerFriend) == false)
            {
                throw new Exception();
            }

            string query = string.Format("DELETE FROM PlayerPlayers WHERE Player_Id = @ID1 AND Player_Id1 = @ID2");

            int number = this.context.Database.ExecuteSqlCommand(query,
                new SqlParameter("@ID1", player.Id),
                new SqlParameter("@ID2", playerFriend.Id));
        }

        public void RegistrateToTournament(PlayerModel player, int tournament)
        {
            if (IsRegistrate(player, tournament))
            {
                throw new Exception();
            }
            var query = string.Format("INSERT INTO PlayerTournaments" +
                                      "(Player_Id, Tournament_Id) " +
                                      "VALUES (@playerId, @tournamentId)");

            int number = this.context.Database.ExecuteSqlCommand(query,
                new SqlParameter("@playerId", player.Id),
                new SqlParameter("@tournamentId", tournament));

            int num = 0;
            num++;
        }

        public void RemoveRegistrateToTournament(PlayerModel player, int tournament)
        {
            if (IsRegistrate(player, tournament) == false)
            {
                throw new Exception();
            }
            var query =
                string.Format(
                    "DELETE FROM PlayerTournaments WHERE Player_Id = @playerId AND Tournament_Id = @tournamentId");
            int number = this.context.Database.ExecuteSqlCommand(query,
                new SqlParameter("@playerId", player.Id),
                new SqlParameter("@tournamentId", tournament));
        } 

        public void InsertPlayer(PlayerModel player)
        {
            var query = string.Format("INSERT INTO PassportInformations " +
                                      "(PassportNumber, Nationality, ExpirationDate) " +
                                      "VALUES (@PassportNumber, @Nationality, @ExpirationDate)");

            int id = GetId();

            int number = this.context.Database.ExecuteSqlCommand(query,
                new SqlParameter("@PassportNumber", player.PassportNumber),
                new SqlParameter("@Nationality", player.Nationality),
                new SqlParameter("@ExpirationDate", player.ExpirationDate));

            query = string.Format("INSERT INTO Players " +
                                      "(Id, PhoneNumber, AccountBalance, VerifyFlag, Login, Password, Surname, FirstName, Sex, Email, Birth, Country_Id, Admin_Id) " +
                                      "VALUES (@Id, @PhoneNumber, @AccountBalance, @VerifyFlag, @Login, @Password, @Surname, @FirstName, @Sex, @Email, @Birth, @Country_Id, @Admin_Id)");

            number = this.context.Database.ExecuteSqlCommand(query,
                new SqlParameter("@Id", id),
                new SqlParameter("@PhoneNumber", player.PhoneNumber),
                new SqlParameter("@AccountBalance", (double)1.0),
                new SqlParameter("@VerifyFlag", false),
                new SqlParameter("@Login", player.Login),
                new SqlParameter("@Password", player.Password),
                new SqlParameter("@Surname", player.Surname),
                new SqlParameter("@FirstName", player.FirstName),
                new SqlParameter("@Sex", player.Sex),
                new SqlParameter("@Email", player.Email),
                new SqlParameter("@Birth", player.Birth),
                new SqlParameter("@Country_Id", player.CountryId),
                new SqlParameter("@Admin_Id", this.AdminId()));
        }

        public int GetId()
        {
            var query = "Select P.Id From Players as P";

            var player = this.context.Database.SqlQuery<int>(query).LastOrDefault();

            return player + 1;
        }

        public int AdminId()
        {
            var query = "Select A.Id From Administrators as A";

            var admin = this.context.Database.SqlQuery<int>(query).FirstOrDefault();

            return admin;
        }

        public void UpdatePlayer(PlayerModel player)
        {
            var query = string.Format("Update [Players] SET " +
                                      "Login = \'{0}\', " +
                                      "Password = \'{1}\', " +
                                      "Surname = \'{2}\', " +
                                      "FirstName = \'{3}\', " +
                                      "PhoneNumber = \'{4}\', " +
                                      "Sex = \'{5}\', " +
                                      "Email = \'{6}\', " +
                                      "Country_Id = {7} " +
                                      "WHERE Id = {8}", 
                                      player.Login, player.Password, player.Surname, player.FirstName, player.PhoneNumber,
                                      player.Sex, player.Email, player.CountryId, player.Id);
            int number = this.context.Database.ExecuteSqlCommand(query);

            query = string.Format("Update [Players] SET Birth = @B WHERE Id = @Id");

            number = this.context.Database.ExecuteSqlCommand(query,
                new SqlParameter("@B", player.Birth),
                new SqlParameter("@Id", player.Id));

            query =
                string.Format(
                    "Update [PassportInformations] SET PassportNumber = @PN, Nationality = @N, ExpirationDate = @ED WHERE Id = @Id");

            number = this.context.Database.ExecuteSqlCommand(query,
                new SqlParameter("@PN", player.PassportNumber),
                new SqlParameter("@N", player.Nationality),
                new SqlParameter("@ED", player.ExpirationDate),
                new SqlParameter("@Id", player.Id));
        }

        public List<CountryModel> GetCountries()
        {
            string query = string.Format("Select C.Id as Id, C.CountryName as Country From Countries as C");
            var countries = this.context.Database.SqlQuery<CountryModel>(query).ToList();
            return countries;
        } 

        public bool IsRegistrate(PlayerModel player, int id)
        {
            string query =
                string.Format(
                    "Select Count(*) From PlayerTournaments as PT where PT.Player_Id = {0} And PT.Tournament_Id = {1}",
                    player.Id, id);
            var result = this.context.Database.SqlQuery<int>(query).ToList().FirstOrDefault();
            return result > 0;
        }

        public TournamentInfoModel GetTournamentInfoModel(int id)
        {
            TournamentInfoModel model = new TournamentInfoModel();
            model.Tournament = GetTournamentById(id);
            model.Rounds = Rounds(id);
            return model;
        }

        public List<RoundModel> Rounds(int id)
        {
            string query = string.Format("Select R.RoomNumber as RoomNumber, " +
                                         "(Select Count(*) From RoundResults as RR " +
                                         "Where RR.TournamentRoom_Id = R.Id) as ParticipantsNumber " +
                                         "From Rounds as R where R.Tournament_Id = {0}", id);
            var rounds = this.context.Database.SqlQuery<RoundModel>(query).ToList();
            return rounds;
        } 

        public TournamentModel GetTournamentById(int id)
        {
            string query =
                string.Format(
                    "Select T.TournamentName as TournamentName, T.Id as Id, T.Schedule as Schedule, A.Id as AdminId, A.Login as Admin, " +
                    "TR.Id as RestrictionId, TR.Fee as Fee, TR.MinimumNumberOfWins as Wins, G.Type as GameType, G.Id as GameTypeId, " +
                    "(Select Count(*) From Rounds as R Where R.Tournament_Id = T.Id) as Rounds," +
                    "(Select Count(*) From PlayerTournaments as PT Where PT.Tournament_Id = T.Id) as Participants " +
                    "From Tournaments as T Inner Join Administrators as A On T.Admin_Id = A.Id " +
                    "Inner Join TournamentRestrictions as TR On TR.Id = T.Restriction_Id " +
                    "Inner Join GameTypes as G On G.Id = T.GameType_Id " +
                    "Where T.Id = {0}", id);
            var tournament = this.context.Database.SqlQuery<TournamentModel>(query).FirstOrDefault();
            return tournament;
        }

        public PlayerModel Player(int id)
        {
            string query = string.Format("Select P.Id as Id, P.Login as Login, P.Password as Password, P.FirstName as FirstName, P.Surname as Surname, " +
                                         "P.Sex as Sex, P.Email as Email, P.Country_Id as CountryId, C.CountryName as Country, " +
                                         "P.PhoneNumber as PhoneNumber, P.Birth as Birth, P.Admin_Id as AdminId, A.Login as Admin, " +
                                         "PP.PassportNumber as PassportNumber, PP.Nationality as Nationality, PP.ExpirationDate as ExpirationDate " +
                                         "From Players as P Inner Join Administrators as A on P.Admin_Id = A.Id " +
                                         "Inner Join Countries as C on P.Country_Id = C.Id " +
                                         "Inner Join PassportInformations as PP on P.Id = PP.Id " +
                                         "Where P.Id = \'{0}\'", id);
            var player = this.context.Database.SqlQuery<PlayerModel>(query).FirstOrDefault();
            return player;
        }

        public List<PlayerRankingModel> Players(PlayerModel player)
        {
            string query = string.Format("Select P.Id as Id, P.Login as Login, P.FirstName as FirstName, " +
                                         "P.Surname as Surname, (Select COALESCE(SUM(RR.Gain), 0) From RoundResults as RR Where RR.Participant_Id = P.Id) as TotalGain " +
                                         "From PlayerPlayers as Pl Join Players as P On P.Id = Pl.Player_Id1 " +
                                         "Where Pl.Player_Id = {0} " +
                                         "ORDER BY TotalGain DESC", player.Id);
            var result = this.context.Database.SqlQuery<PlayerRankingModel>(query).ToList();
            return result;
        }
        
        public PlayerModel Player(string login, string password)
        {
            string query = string.Format("Select P.Id as Id, P.Login as Login, P.Password as Password, P.FirstName as FirstName, P.Surname as Surname, " +
                                         "P.Sex as Sex, P.Email as Email, P.Country_Id as CountryId, C.CountryName as Country, " +
                                         "P.PhoneNumber as PhoneNumber, P.Birth as Birth, P.Admin_Id as AdminId, A.Login as Admin, " +
                                         "PP.PassportNumber as PassportNumber, PP.Nationality as Nationality, PP.ExpirationDate as ExpirationDate " +
                                         "From Players as P Inner Join Administrators as A on P.Admin_Id = A.Id " +
                                         "Inner Join Countries as C on P.Country_Id = C.Id " +
                                         "Inner Join PassportInformations as PP on P.Id = PP.Id " +
                                         "Where P.Login = \'{0}\' And P.Password = \'{1}\'", login, password);
            var player = this.context.Database.SqlQuery<PlayerModel>(query).FirstOrDefault();
            return player;
        }

        public bool IsFriend(PlayerModel player, PlayerModel friend)
        {
            string query =
                string.Format("Select Count(*) From PlayerPlayers as PP Where PP.Player_Id = {0} And PP.Player_Id1 = {1}",
                    player.Id, friend.Id);
            int count = this.context.Database.SqlQuery<int>(query).ToList().FirstOrDefault();
            return count == 1;
        }

        public List<TournamentModel> GetTournaments(string type)
        {
            if (string.IsNullOrEmpty(type))
                type = "All";
            string query = String.Format("Select COUNT(*) From GameTypes as GT Where GT.Type = \'{0}\'", type);
            var count = (this.context.Database.SqlQuery<int>(query).ToList()).FirstOrDefault();
            if (count == 0)
            {
                query =
                    string.Format(
                        "Select T.TournamentName as TournamentName, T.Id as Id, T.Schedule as Schedule, A.Id as AdminId, A.Login as Admin, " +
                        "TR.Id as RestrictionId, TR.Fee as Fee, TR.MinimumNumberOfWins as Wins, G.Type as GameType, G.Id as GameTypeId, " +
                        "(Select Count(*) From Rounds as R Where R.Tournament_Id = T.Id) as Rounds," +
                        "(Select Count(*) From PlayerTournaments as PT Where PT.Tournament_Id = T.Id) as Participants " +
                        "From Tournaments as T Inner Join Administrators as A On T.Admin_Id = A.Id " +
                        "Inner Join TournamentRestrictions as TR On TR.Id = T.Restriction_Id " +
                        "Inner Join GameTypes as G On G.Id = T.GameType_Id");
                var tournaments = this.context.Database.SqlQuery<TournamentModel>(query);
                var list = tournaments.ToList();
                return list;
            }
            else
            {
                query = String.Format("Select Id From GameTypes as GT Where GT.Type = \'{0}\'", type);
                int GameTypeId = (this.context.Database.SqlQuery<int>(query)).ToList().FirstOrDefault();
                query =
                    string.Format(
                        "Select T.TournamentName as TournamentName, T.Id as Id, T.Schedule as Schedule, A.Id as AdminId, A.Login as Admin, " +
                        "TR.Id as RestrictionId, TR.Fee as Fee, TR.MinimumNumberOfWins as Wins, G.Type as GameType, G.Id as GameTypeId, " +
                        "(Select Count(*) From Rounds as R Where R.Tournament_Id = T.Id) as Rounds," +
                        "(Select Count(*) From PlayerTournaments as PT Where PT.Tournament_Id = T.Id) as Participants " +
                        "From Tournaments as T Inner Join Administrators as A On T.Admin_Id = A.Id " +
                        "Inner Join TournamentRestrictions as TR On TR.Id = T.Restriction_Id " +
                        "Inner Join GameTypes as G On G.Id = T.GameType_Id " +
                        "Where T.GameType_Id = {0}", GameTypeId);
                var tournaments = this.context.Database.SqlQuery<TournamentModel>(query);
                var list = tournaments.ToList();
                return list;
            }
        }

        public List<GameTypeModel> GetGameTypes()
        {
            var types = this.context.Database.SqlQuery<GameTypeModel>("Select GT.Type as GameType From GameTypes as GT").ToList();
            return types;
        }

        public List<PlayerRankingModel> Players()
        {
            string query = string.Format("Select P.Id as Id, P.Login as Login, P.FirstName as FirstName, P.Surname as Surname, " +
                                         "(Select COALESCE(SUM(RR.Gain), 0) From RoundResults as RR Where RR.Participant_Id = P.Id) as TotalGain From Players as P " +
                                         "ORDER BY TotalGain DESC");
            var player = this.context.Database.SqlQuery<PlayerRankingModel>(query);
            return player.ToList();
        }
    }
}
