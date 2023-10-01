using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2
{
    internal class Program
    {
        static void TestConstructor1()
        {
            IntArray obj = new IntArray(20);
            Console.WriteLine("Gia tri mang phat sinh: ");
            obj.Output();
        }
        static void TestConstructor2()
        {
            int[] a = { 4, 7, 9, 10, 20, 8, 3, 17, 10, 6 };
            IntArray obj = new IntArray(a);
            Console.WriteLine("Gia tri mang: ");
            obj.Output();
        }
        static void TestConstructor3()
        {
            IntArray obj1=new IntArray();
            obj1.Input();
            Console.WriteLine("Gia tri mang: ");
            obj1.Output();
            IntArray obj2 = new IntArray(obj1);
            Console.WriteLine("Gia tri mang copy: ");
            obj2.Output();
        }
        static void TestTimTuanTu()
        {
            int k, x, kq;
            Console.Write("Nhap so luong phan tu: ");
            int.TryParse(Console.ReadLine(), out k); ;
            IntArray obj=new IntArray(k);
            Console.WriteLine("Cac phan tu: ");
            obj.Output();

            Console.WriteLine("Gia tri can tim x= ");
            int.TryParse(Console.ReadLine(), out x);

            kq = obj.SequentialSearch(x);
            if (kq == -1)
                Console.WriteLine($"Khong ton tai {x}");
            else
                Console.WriteLine($"Co {x} tai vi tri {kq}");
        }
        static void TestTimNhiPhan()
        {
            int k, x, kq;
            Console.Write("Nhap so luong phan tu: ");
            int.TryParse(Console.ReadLine(), out k);
            IntArray obj = new IntArray(k);
            obj.ShakerSort();
            Console.WriteLine("Cac phan tu: ");
            obj.Output();

            Console.WriteLine("Gia tri can tim x= ");
            int.TryParse(Console.ReadLine(), out x);

            kq = obj.BinarySearch(x);
            if (kq == -1) Console.WriteLine($"Khong ton tai {x}");
            else Console.WriteLine($"Ton tai {x} tai vi tri {kq}");
        }
        static void TestInterchangeSort()
        {
            IntArray obj = new IntArray(10);
            IntArray objTam = new IntArray(obj);
            Console.WriteLine("\n>>Mang ban dau:");
            objTam.Output();
            objTam.InterchangeSort();
            Console.WriteLine("\n>>Interchange Sort:");
            objTam.Output();
        }
        static void TestBurbleSort()
        {
            IntArray obj = new IntArray(10);
            IntArray objTam = new IntArray(obj);
            Console.WriteLine("\n>>Mang ban dau:");
            objTam.Output();
            objTam.BurbleSort();
            Console.WriteLine("\n>>Burble Sort:");
            objTam.Output();
        }
        static void TestSelectionSort()
        {
            IntArray obj = new IntArray(10);
            IntArray objTam = new IntArray(obj);
            Console.WriteLine("\n>>Mang ban dau:");
            objTam.Output();
            objTam.SelectionSort();
            Console.WriteLine("\n>>Selection Sort:");
            objTam.Output();
        }
        static void TestInsertionSort()
        {
            IntArray obj = new IntArray(10);
            IntArray objTam = new IntArray(obj);
            Console.WriteLine("\n>>Mang ban dau:");
            objTam.Output();
            objTam.InsertionSort();
            Console.WriteLine("\n>>Insertion Sort:");
            objTam.Output();
        }
        static void TestQuickSort()
        {
            IntArray obj = new IntArray(10);
            IntArray objTam = new IntArray(obj);
            Console.WriteLine("\n>>Mang ban dau:");
            objTam.Output();
            objTam.QuickSort();
            Console.WriteLine("\n>>Quick Sort:");
            objTam.Output();
        }
        static void TestShellSort()
        {
            IntArray obj = new IntArray(10);
            IntArray objTam = new IntArray(obj);
            Console.WriteLine("\n>>Mang ban dau:");
            objTam.Output();
            objTam.ShellSort();
            Console.WriteLine("\n>>Shell Sort:");
            objTam.Output();
        }
        static void TestShakerSort()
        {
            IntArray obj = new IntArray(10);
            IntArray objTam = new IntArray(obj);
            Console.WriteLine("\n>>Mang ban dau:");
            objTam.Output();
            objTam.ShakerSort();
            Console.WriteLine("\n>>Shaker Sort:");
            objTam.Output();
        }
        static void TestMergeSort()
        {
            IntArray obj = new IntArray(10);
            IntArray objTam = new IntArray(obj);
            Console.WriteLine("\n>>Mang ban dau:");
            objTam.Output();
            objTam.MergeSort();
            Console.WriteLine("\n>>Merge Sort:");
            objTam.Output();
        }

        static void Main(string[] args)
        {
            //TestConstructor1();
            //TestConstructor2();
            //TestConstructor3();
            //TestTimTuanTu();
            //TestTimNhiPhan();
            //TestInterchangeSort();
            //TestBurbleSort();
            TestSelectionSort();
            //TestInsertionSort();
            //TestQuickSort();
            //TestShellSort();
            //TestShakerSort();
            //TestMergeSort();
            Console.ReadKey();
        }
    }
}
