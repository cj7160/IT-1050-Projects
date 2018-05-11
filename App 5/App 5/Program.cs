using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_5
{
    class Program
    {
        public const int size = 8;
        public static string[][] board;

        static void Main(string[] args)
        {
            CreateBoard();

            int tx;
            int ty;
            int dx;
            int dy;
            int x = 1;

            while (x == 1)
            {
                System.Console.Clear();
                PrintBoard();

                System.Console.WriteLine("Please enter X axis location");
                tx = int.Parse(System.Console.ReadLine());

                System.Console.WriteLine("Please enter y axis location");
                ty = int.Parse(System.Console.ReadLine());

                System.Console.WriteLine("Please enter desired X axis location");
                dx = int.Parse(System.Console.ReadLine());

                System.Console.WriteLine("Please enter desired y axis location");
                dy = int.Parse(System.Console.ReadLine());

                
                if (board[tx][ty] == "X")
                {
                    
                    if (board[dx][dy] == " ")
                    {
                        board[tx][ty] = " ";
                        board[dx][dy] = "X";
                    }
                    else
                    {
                        System.Console.WriteLine("Point is already taken");
                    }                   
                }
                else
                {
                    System.Console.WriteLine("invaled point. Try again");
                }
            }
        }

        static void CreateBoard()
        {
            board = new string[size][];

            for (int i = 0; i < size; i++)
            {
                board[i] = new string[size];

                for (int j = 0; j < size; j++)
                {
                   
                    board[i][j] = (i < 2 || i > 5) ? "X" : " ";
                }
            }
        }

        static void PrintBoard()
        {
            PrintLine();

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                   
                    System.Console.Write(" | " + board[i][j]);
                }

                System.Console.Write(" |");
                System.Console.WriteLine();
                PrintLine();
            }
        }

        static void PrintLine()
        {
            System.Console.WriteLine(" +-------------------------------+");
        }
   
    }
       
}
  
 