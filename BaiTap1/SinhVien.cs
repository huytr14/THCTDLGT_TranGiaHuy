using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap1
{
    internal class SinhVien
    {
        private string maSo;
        private string hoTen;
        private string chuyenNganh;
        private int namSinh;
        private float diemTB;
        private string Loai;

        //Properties
        public string maso
        {
            get { return maSo; }
            set { maSo = value; }
        }
        public string hoten
        {
            get { return hoTen; }
            set { hoTen = value; }
        }
        public string chuyennganh
        {
            get { return chuyenNganh; }
            set { chuyenNganh = value; }
        }
        public int namsinh
        {
            get { return namSinh; }
            set { namSinh = value; }

        }
        public float diemtb
        {
            get { return diemTB; }
            set { diemTB = value; }
        }
        public string loai
        {
            get { return Loai; }
            set { Loai = value; }
        }

        //Contructors
        public SinhVien() { }
        public SinhVien(string ms,string ht,string cn,int ns,float dtb)
        {
            this.maSo = ms;
            this.hoTen = ht;
            this.chuyenNganh = cn;
            this.namSinh = ns;
            this.diemTB = dtb;
            XepLoai();
        }

        //Method
        public bool KiemTraNamSinh(int ns)
        {
            if (DateTime.Now.Year - ns < 17 && DateTime.Now.Year - ns > 70)
            {
                return false;
            }
            return true;
        }
        public bool KiemTraDiemTB(float dtb)
        {
            if (dtb < 0 && dtb > 10)
            {
                return false;
            }
            return true;
        }
        public void XepLoai()
        {
            if(diemTB < 5)
            {
                loai = "Kém";
            }
            if(diemTB >=5 && diemTB <7)
            {
                loai = "TB";
            }
            if(diemTB >=7 && diemTB < 8)
            {
                loai = "Khá";
            }
            if (diemTB >= 8)
            {
                loai = "Giỏi";
            }
        }
        public void Nhap()
        {
            Console.WriteLine("MSSV");
            maSo = Console.ReadLine();
            Console.WriteLine("Ho va ten");
            hoten = Console.ReadLine();
            Console.WriteLine("Chuyen nganh");
            chuyenNganh = Console.ReadLine();
            Console.WriteLine("Nam sinh");
            namSinh = int.Parse(Console.ReadLine());
            Console.WriteLine("DiemTB");
            diemTB = float.Parse(Console.ReadLine());
            XepLoai();

        }
        public void Xuat()
        {
            Console.WriteLine(maSo);
            Console.WriteLine(hoTen);
            Console.WriteLine(chuyenNganh);
            Console.WriteLine(namSinh);
            Console.WriteLine(diemTB);
            Console.WriteLine(loai);
        }
    }
}
