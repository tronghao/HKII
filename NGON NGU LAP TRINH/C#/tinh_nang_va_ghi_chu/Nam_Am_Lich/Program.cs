using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nam_Am_Lich
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Can = { "Canh", "Tan", "Nham", "Quy", "Giap", "At", "Binh", "Dinh", "Mau.", "Ky" };
            string[] Chi = {"Than", "Dau", "Tuat", "Hoi", "Ty/", "Suu", "Dan", "Meo", "Thinh", "Ty.", "Ngo", "Mui"};
            Console.Write("Nhap nam can xac dinh: ");
            int Nam;
            string Year = Console.ReadLine();
            if(Int32.TryParse(Year, out Nam)==false)
            {
                Console.WriteLine("Ban nhap sai!");
                Console.ReadKey();
                return;
            }
            int start, end;
            start = Nam % 10;
            end = Nam % 12;
            Console.WriteLine("{0} am lich se la {1} {2}", Nam, Can[start], Chi[end]);
            Console.ReadKey();
        }
    }
}
