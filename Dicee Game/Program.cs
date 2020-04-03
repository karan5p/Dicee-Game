using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dicee_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            //todo: dont make this a hardcode and let the user add asmany players
            DiceGame game = new DiceGame(2);
            Console.WriteLine("Name of Player 1?, Then press Enter");
            Player player1 = new Player();
            player1.Name = Console.ReadLine();
            Console.WriteLine("Name of Player 2?, Then press Enter");
            Player player2 = new Player();
            player2.Name = Console.ReadLine();
            Console.WriteLine("Name of Player 3?, Then press Enter");
            Player player3 = new Player();
            player3.Name = Console.ReadLine();

            game.AddPlayer(player1);
            game.AddPlayer(player2);
            game.AddPlayer(player3);

            Console.WriteLine("Players Names:");
            foreach (var player in game.Players)
            {
                Console.WriteLine(player.Name);
            }


            game.Start();

            Console.WriteLine("Players Scores:");
            foreach (var player in game.Players)
            {
                Console.WriteLine(player.Score);
            }

            //todo:winner here!


            Console.WriteLine("\nPress Enter to exit");
            Console.ReadLine(); //pause
        }
    }
}
