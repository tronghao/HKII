using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ba12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //giải phương trình ax+b=0;
            string a, b, c;
            Console.WriteLine("Nhập vào phương trình ax+b=0: ");
            Console.Write("\t a= ");
            a = Console.ReadLine();
            Console.Write("\t b= ");
            b = Console.ReadLine();
      
            int a1, b1, c1;
            if (Int32.TryParse(a, out a1) == false || Int32.TryParse(b, out b1) == false)
            {
                Console.WriteLine("Lỗi Nhập Liệu");
            }
            else
            {
                if (a1 == 0 && b1 == 0) Console.WriteLine("Phương trình vô số nghiệm!");
                else if (a1 == 0 && b1 != 0) Console.WriteLine("Phương trình vô nghiệm!");
                else if (a1 != 0) Console.WriteLine("Phương trình có nghiệm: x = {0}", -b1/(float)a1);
            }
            Console.ReadKey();
        }
    }
}
