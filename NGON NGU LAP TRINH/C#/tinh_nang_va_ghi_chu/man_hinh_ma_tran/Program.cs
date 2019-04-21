using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace man_hinh_ma_tran
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 0, max = 100;
            int cot = 14, dong = 20000;
            Random rand = new Random();
            int giaTri;
            for (int i = 0; i < dong; i++)
            {

                for (int j = 0; j < cot; j++)
                {
                    giaTri = rand.Next(min, max);
                    Console.Write("\t{0}", giaTri);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
