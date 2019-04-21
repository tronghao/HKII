using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //nhập vào 3 số in ra theo định dạng số a, số b, số c
            string a, b, c;
            Console.WriteLine("Nhập vào 3 số: ");
            Console.Write("\t Số Thứ Nhất: ");
            a = Console.ReadLine();
            Console.Write("\t Số Thứ Hai: ");
            b = Console.ReadLine();
            Console.Write("\t Số Thứ Ba: ");
            c = Console.ReadLine();
            int a1, b1, c1;
            if (Int32.TryParse(a, out a1) == false || Int32.TryParse(b, out b1) == false || Int32.TryParse(c, out c1) == false)
            {
                Console.WriteLine("Lỗi Nhập Liệu");
            }
            else 
            {
                Console.WriteLine("Số " + a1 + ", Số " + b1 + ", Số " + c1);
            }
            Console.ReadKey();
        }
    }
}
