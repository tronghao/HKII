using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ve_HCN
{
    class Program
    {
        static void Main(string[] args)
        {
            int cR = 5, cD = 10; //25,50
            char dVien = '*', ruot = '-';
            for (int i = 0; i < cR; i++)
            {
                Console.Write("    "); //Ve HCN
                for (int j = 0; j < cD; j++)
                {
                    
                    if (i == 0 || i == cR - 1)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(dVien);
                    }
                    else if (j == 0 || j == cD - 1)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(dVien);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(ruot);
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("  Happy New Year!!");  //Ve HCN
            Console.ReadKey();
        }
        
    }
}
