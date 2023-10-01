using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap1
{
    internal class MangSinhVien:SinhVien
    {
        
        private SinhVien[] danhSachSinhVien;
        private int soLuongSinhVien;

        public MangSinhVien(int n)
        {
            danhSachSinhVien = new SinhVien[n];
            soLuongSinhVien = 0;
        }

        public void NhapDanhSach()
        {

            for (int i = 0; i < danhSachSinhVien.Length; i++)
            {
                Console.WriteLine($"Nhập thông tin cho sinh viên thứ {i + 1}:");
                SinhVien sv = new SinhVien();
                do
                {
                    Console.Write("Mã số sinh viên: ");
                    sv.maso = Console.ReadLine();
                }
                while (TonTai(sv.maso, i) == true) ;
                Console.Write("Họ và tên: ");
                sv.hoten = Console.ReadLine();
                Console.Write("Chuyên ngành: ");
                sv.chuyennganh = Console.ReadLine();
                Console.Write("Năm sinh: ");
                sv.namsinh = int.Parse(Console.ReadLine());
                Console.Write("Điểm trung bình tích lũy: ");
                sv.diemtb = float.Parse(Console.ReadLine());

                danhSachSinhVien[i] = sv;
            }

            soLuongSinhVien = danhSachSinhVien.Length;
        }

        public void XuatDanhSach()
        {
            Console.WriteLine("\nDanh sách sinh viên:");

            for (int i = 0; i < soLuongSinhVien; i++)
            {
                Console.WriteLine($"Sinh viên thứ {i + 1}:");
                Console.WriteLine("Mã số sinh viên: " + danhSachSinhVien[i].maso);
                Console.WriteLine("Họ và tên: " + danhSachSinhVien[i].hoten);
                Console.WriteLine("Chuyên ngành: " + danhSachSinhVien[i].chuyennganh);
                Console.WriteLine("Năm sinh: " + danhSachSinhVien[i].namsinh);
                Console.WriteLine("Điểm trung bình tích lũy: " + danhSachSinhVien[i].diemtb);
                Console.WriteLine();
            }
        }

        public bool TonTai( string msx,int vt)
        {
            for(int i = 0; i < vt; i++)
            {
                if (danhSachSinhVien[i].maso.CompareTo(msx) == 0) ;
                return true;
            }
            return false;
        }
    }
}
