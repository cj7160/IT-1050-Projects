

namespace Weekly_KD_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string teamname;
            string playername;

            int age;

            float match1kills;
            float match2kills;
            float match1deaths;
            float match2deaths;

            
            bool canplayasdps;

            System.Console.Write("Input team name. ");
            teamname = System.Console.ReadLine();

            System.Console.Write("Input player name. ");
            playername = System.Console.ReadLine();

            System.Console.Write("Input player age. ");
            age = int.Parse(System.Console.ReadLine());

            System.Console.Write("Are they a dps player? ");
           bool dpsplayer = System.Console.ReadLine().ToLower().StartsWith("y");

            System.Console.Write("Input match 1 kills. ");
            match1kills = float.Parse(System.Console.ReadLine());

            System.Console.Write("Input match 1 deaths. ");
            match1deaths = float.Parse(System.Console.ReadLine());

            System.Console.Write("Input match 2 kills. ");
            match2kills = float.Parse(System.Console.ReadLine());

            System.Console.Write("Input match 2 deaths. ");
            match2deaths = float.Parse(System.Console.ReadLine());

            float weekKD = (match1kills + match2kills) / (match1deaths + match2deaths);

            canplayasdps = dpsplayer && age >= 18;

            System.Console.WriteLine("Weekly K/D results for " + playername + " of the " + teamname);
            System.Console.WriteLine(canplayasdps);
            System.Console.WriteLine(weekKD);
            System.Console.ReadKey();








        }
    }
}
