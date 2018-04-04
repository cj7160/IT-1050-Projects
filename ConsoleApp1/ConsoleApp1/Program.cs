

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string teamname;
            string playername;

            float match1kills;
            float match2kills;
            float match1deaths;
            float match2deaths;

            

            System.Console.Write("Input team name. ");
            teamname = System.Console.ReadLine();

            System.Console.Write("Input player name. ");
            playername = System.Console.ReadLine();

            System.Console.Write("Input match 1 kills. ");
            match1kills = float.Parse(System.Console.ReadLine());

            System.Console.Write("Input match 1 deaths.");
            match1deaths = float.Parse(System.Console.ReadLine());

            System.Console.Write("Input match 2 kills. ");
            match2kills = float.Parse(System.Console.ReadLine());

            System.Console.Write("Input match 2 deaths. ");
            match2deaths = float.Parse(System.Console.ReadLine());

            float weekKD = (match1kills + match2kills) / (match1deaths + match2deaths);

            System.Console.WriteLine("Weekly K/D results for " + playername + " of the " + teamname);
            System.Console.WriteLine(weekKD);
            System.Console.ReadKey();








        }
    }
}
