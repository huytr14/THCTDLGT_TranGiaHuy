using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap1
{
    internal class Program
    {
        static void TestSinhVien()
        {
            SinhVien svA = new SinhVien();
            svA.Nhap();
            Console.WriteLine("Thong tin svA");
            svA.Xuat();

            SinhVien svB = new SinhVien("18DH001", "Lam Thanh Ngoc", "CNPM", 2000, 7.6F);
            Console.WriteLine("Thong tin svB");
            svB.Xuat();

            SinhVien svC = new SinhVien();
            svC.maso = svB.maso;
            svC.hoten = svB.hoten;
            svC.chuyennganh = svB.chuyennganh;
            svC.namsinh = svB.namsinh;
            svC.diemtb = svB.diemtb;
            Console.WriteLine("Thong tin svC");
            svC.Nhap();
            svC.Xuat();
            svB.Xuat();
        }
        static void TestMangSinhVien()
        {
            Console.Write("Nhập số lượng sinh viên: ");
            int n = int.Parse(Console.ReadLine());
            if (n > 0 && n <= 1000000)
            {
                MangSinhVien mangSV = new MangSinhVien(n);
                mangSV.NhapDanhSach();
                mangSV.XuatDanhSach();
            }

            
        }
        static void Main(string[] args)
        {
            TestMangSinhVien();
            Console.ReadLine();
        }
    }
}
