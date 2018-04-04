

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player();
            player1.Playerinformation();


            Player player2 = new Player();
            player2.Playerinformation();

            player1.counterpart = player2;
            player2.counterpart = player1;

            System.Console.WriteLine("Player information for " + player1.StageName + " of the " + player1.CityName + ".");
            System.Console.WriteLine("Their KD for this map was " + player1.KD + ".");
            System.Console.WriteLine("Their enemy team counterpart was " + player1.counterpart.StageName + ".");
            System.Console.WriteLine("Press any key to continue...");
            System.Console.ReadKey();

            System.Console.WriteLine("Player information for " + player2.StageName + " of the " + player2.CityName + ".");
            System.Console.WriteLine("Their KD for this map was " + player2.KD + ".");
            System.Console.WriteLine("Thier enemy team counterpart was " + player2.counterpart.StageName + ".");
            System.Console.WriteLine("Press any key to continue...");
            System.Console.ReadKey();

            System.Console.WriteLine("The total KD between the players was " + Player.totalKD() + ".");

            System.Console.WriteLine("Press any key to continue...");
            System.Console.ReadKey();


        }
    }
}
