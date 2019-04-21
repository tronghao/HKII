using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nhap
{
    interface kill
    {
        void attack();
    }
    class kiem : kill
    {
        public void attack()
        {
            Console.WriteLine("Kiem sat thuong 20%... \n\n");
        }
    }
    class sung : kill
    {
        public void attack()
        {
            Console.WriteLine("Sung sat thuong 80%... \n\n");
        }
    }
    class ten : kill
    {
        public void attack()
        {
            Console.WriteLine("Cung ten sat thuong 30%... \n\n");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            kill a = new kiem();
            kill b = new sung();
            kill c = new ten();
            a.attack();
            Console.ReadKey(true);
            b.attack();
            Console.ReadKey(true);
            c.attack();
            Console.ReadKey(true);

        }
    }
}
