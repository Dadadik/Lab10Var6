using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10Var6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] Q = new int[8, 8];       
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j<8; j++)
                {
                    Q[i, j] = 0;
                }
            }
            for (int j = 7; j>=3 ; j--)
            {
                for (int i = 7-j; i <= j; i++)
                {
                    Q[i, j] = 1;
                }
            }
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.ForegroundColor = (Q[i, j] == 1) ? ConsoleColor.Red :
                   ConsoleColor.White;
                    Console.Write($"{Q[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine();

        }
    }
}
