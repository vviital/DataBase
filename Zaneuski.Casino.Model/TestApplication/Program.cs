using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zaneuski.Casino.Data;
using Zaneuski.Casino.Model;

namespace TestApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            CasinoContext casino = new CasinoContext();
            int num = 0;
            IQueryable<Player> players = from c in casino.Players
                        where c.Sex == true
                        select c;

           
            players = from c in casino.Players
                where c.Admin != null && c.Admin.FirstName == "Vitali"
                select c;
            foreach (var player in players)
            {
                Console.WriteLine("{0} player have {1} name", player.Login, player.FirstName);
            }
        }
    }
}
