using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sinh_Vien
{
    public struct sinhVien
    {
        public string mssv;
        public string hoTenSV;
        public string lop;
        public int namSinh;

    }
    class Program
    {
        
        static void Main(string[] args)
        {
            int n;
            lamlai1:
            Console.Write("Nhap so luong SV: ");
            if (Int32.TryParse(Console.ReadLine(), out n) == false)
            {
                Console.Write("Ban nhap sai!\n");
                goto lamlai1;
            }
            sinhVien[] SV = new sinhVien[n];
            Console.WriteLine("\nNhap Thong Tin Sinh Vien!");
            nhapnSV(SV, n);
            xuatnSV(SV, n);
            Console.ReadLine();
        }

        static void nhapSV(out sinhVien SV)
        {
            Console.Write("Nhap MSSV: ");
            SV.mssv = Console.ReadLine();

            Console.Write("Nhap Ho Ten SV: ");
            SV.hoTenSV = Console.ReadLine();

            Console.Write("Nhap Lop: ");
            SV.lop = Console.ReadLine();

            lamlai:
            Console.Write("Nhap Nam Sinh: ");
            string tam=Console.ReadLine();
            if(Int32.TryParse(tam, out SV.namSinh)==false)
            {
                Console.Write("Ban nhap sai!\n");
                goto lamlai;
            }
        }
        static void xuatSV(sinhVien SV)
        {
            Console.WriteLine("{0}\t{1}\t{2}\t{3}", SV.mssv, SV.hoTenSV, SV.lop, SV.namSinh);
        }
        static void nhapnSV(sinhVien[] SV, int n)
        {
           
            for (int i = 0; i < n; i++)
            {
                nhapSV(out SV[i]); 
                Console.WriteLine("====================================");
            }
           
        }
        static void xuatnSV(sinhVien[] SV, int n)
        {
            Console.WriteLine("====================================");
            Console.WriteLine("Thong Tin Sinh Vien:");
            Console.WriteLine("{0}\t{1}\t{2}\t{3}", "mssv", "hoTenSV", "lop", "namSinh");
            for (int i = 0; i < n; i++)
            {
                xuatSV(SV[i]);
            }
            Console.WriteLine("====================================");
        }
    }
}
