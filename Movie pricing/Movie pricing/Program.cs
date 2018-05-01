using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_pricing
{
    class Program
    {
        static void Main(string[] args)
        {
            double ticketprice;
            double discount1;
            double discount2;
            double totalprice;
            

            System.Console.WriteLine("Is it a Matinee or not? Answer yes or no. ");
            string time = System.Console.ReadLine();

            if (time == "yes")
            {
                System.Console.WriteLine("Number of Adults: ");
                double adultprice = (double.Parse(System.Console.ReadLine())) * 5.99;
                System.Console.WriteLine("Number of Children: ");
                double kidprice = (double.Parse(System.Console.ReadLine())) * 3.99;
                System.Console.WriteLine("Number of Seniors: ");
                double seniorprice = (double.Parse(System.Console.ReadLine())) * 4.50;
                ticketprice = adultprice + kidprice + seniorprice;
            }
            else
            {
                System.Console.WriteLine("Number of Adults: ");
                double adultprice = (double.Parse(System.Console.ReadLine())) * 10.99;
                System.Console.WriteLine("Number of Children: ");
                double kidprice = (double.Parse(System.Console.ReadLine())) * 6.99;
                System.Console.WriteLine("Number of Seniors: ");
                double seniorprice = (double.Parse(System.Console.ReadLine())) * 8.50;
                ticketprice = adultprice + kidprice + seniorprice;

                if (ticketprice >= 20.97)
                {
                    System.Console.WriteLine("You get a FREE bag of Popcorn!!! ");
                }
            }

            const double smallpopP = 3.50;
            const double largepopP = 5.99;
            const double hotdogP = 3.99;
            const double popcornP = 4.50;
            const double candyP = 1.99;

            double ConcessionsPrice = 0;

            System.Console.Write("How many Small Pops? ");
            double SmallPoPNumb = double.Parse(System.Console.ReadLine());
            ConcessionsPrice += SmallPoPNumb * smallpopP;

            System.Console.Write("How many Large Pops? ");
            ConcessionsPrice += (double.Parse(System.Console.ReadLine())) * largepopP;

            System.Console.Write("How many Hot Dogs? ");
            ConcessionsPrice += (double.Parse(System.Console.ReadLine())) * hotdogP;

            System.Console.Write("How many Popcorns? ");
            double PopcornNumb = double.Parse(System.Console.ReadLine());
            ConcessionsPrice += PopcornNumb * popcornP;

            System.Console.Write("How many Candys? ");
            double candyNumb = double.Parse(System.Console.ReadLine());
            ConcessionsPrice += (candyNumb * candyP);

                discount1 = (candyNumb / 4) * 1.99;

            var min = Math.Min(PopcornNumb, SmallPoPNumb);

            discount2 = min * 2;

            totalprice = (ticketprice + ConcessionsPrice) - (discount1 + discount2);

            System.Console.WriteLine("Your total price is " + totalprice);
            System.Console.ReadKey();

            
            

            
            

        }


                
            



        
    }
}
