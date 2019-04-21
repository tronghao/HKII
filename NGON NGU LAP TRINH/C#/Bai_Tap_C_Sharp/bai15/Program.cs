using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bai15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //nhập vào ngày tháng năm in ra thứ trong tuần
            string a, b, c;
            Console.WriteLine("Nhập vào Ngày Tháng Năm: ");
            Console.Write("\t Ngày: ");
            a = Console.ReadLine();
            Console.Write("\t Tháng: ");
            b = Console.ReadLine();
            Console.Write("\t Năm: ");
            c = Console.ReadLine();
            int a1, b1, c1;
            if (Int32.TryParse(a, out a1) == false || Int32.TryParse(b, out b1) == false || Int32.TryParse(c, out c1) == false)
            {
                Console.WriteLine("Lỗi Nhập Liệu");
            }
            else
            {
                DateTime dt = new DateTime(c1, b1, a1);
                Console.WriteLine(" => " + dt.DayOfWeek);
            }
            Console.ReadKey();
        }
    }
}
