using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace hoc_c_sharp_coban
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap Nam Can Xac Dinh: ");
            string Year = Console.ReadLine();
            int Nam, start, end; 
            string Can="", Chi="";
            if (Int32.TryParse(Year, out Nam) == false)
            {
                Console.WriteLine("Ban nhap sai!");
                Console.ReadKey();
                return;
            }
            else 
            {
                start = Nam % 10;
                end = Nam % 12;
                switch (start)
                {
                    case 0: Can = "Canh"; break;
                    case 1: Can = "Tan"; break;
                    case 2: Can = "Nham"; break;
                    case 3: Can = "Quy"; break;
                    case 4: Can = "Giap"; break;
                    case 5: Can = "At"; break;
                    case 6: Can = "Binh/"; break;
                    case 7: Can = "Dinh"; break;
                    case 8: Can = "Mau."; break;
                    case 9: Can = "Ki?"; break;
                }
                switch (end)
                {
                    case 0: Chi = "Than"; break;
                    case 1: Chi = "Dau"; break;
                    case 2: Chi = "Tuat"; break;
                    case 3: Chi = "Hoi."; break;
                    case 4: Chi = "Ty/"; break;
                    case 5: Chi = "Suu"; break;
                    case 6: Chi = "Dan"; break;
                    case 7: Chi = "Meo."; break;
                    case 8: Chi = "Thinh"; break;
                    case 9: Chi = "Ty."; break;
                    case 10: Chi = "Ngo."; break;
                    case 11: Chi = "Mui"; break;
                } 
                Console.Write("{0} am lich se la: {1} {2}", Nam, Can, Chi);
                Console.ReadKey();
            }
            
            
        }
    }
}
