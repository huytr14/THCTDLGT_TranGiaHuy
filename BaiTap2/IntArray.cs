using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2
{
    public class IntArray
    {
        private int[] array;

        public int[] Array
        {
            get { return array; }
            set { array = value; }
        }

        public IntArray()
        {
            array = new int[0];
        }

        public IntArray(int k)
        {
            if (k <= 0 || k > 1000000)
            {
                Console.WriteLine("Vui long nhap so khac");
            }

            array = new int[k];
            Random random = new Random();

            for (int i = 0; i < k; i++)
            {
                array[i] = random.Next(1, 201);
            }
        }

        public IntArray(int[] a)
        {
            array = new int[a.Length];
            a.CopyTo(array, 0);
        }

        public IntArray(IntArray obj)
        {
            array = new int[obj.Array.Length];
            obj.Array.CopyTo(array, 0);
        }

        public void Input()
        {
            Console.WriteLine("Nhap so phan tu cho mang: ");
            int n=int.Parse(Console.ReadLine());
            array=new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhập giá trị cho phần tử thứ {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }
        }

        public void Output()
        {
            Console.WriteLine("Các phần tử trong mảng:");

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Phần tử thứ {i + 1}: {array[i]}");
            }
        }
        public void swap(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }


        public int SequentialSearch(int x)
        {

            for (int i = 0; i < array.Length; i++)
            {

                if (array[i] == x)
                {
                    return i;
                }
            }

            return -1;
        }

        public int BinarySearch(int x)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (array[mid] == x)
                {
                    return mid;
                }
                else if (array[mid] < x)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return -1;
        }
        public void InterchangeSort()
        {
            int n = array.Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (array[i] > array[j])
                    {
                        swap(ref array[i], ref array[j]);
                    }
                }
            }
        }


        public void BurbleSort()
        {
            for (int i = 0; i <= array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                        swap(ref array[j], ref array[j + 1]);
                }
            }
        }

        public void SelectionSort()
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
               int  min = i;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[min])
                        min = j;
                }
                swap(ref i, ref min);
            }

        }
        public void InsertionSort()
        {
            for (int i = 1; i < array.Length; i++)
            {
                int key = array[i];
                int j = i - 1;

                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = key;
            }
        }
        public void QuickSort()
        {
            QuickSort(0, array.Length - 1);
        }

        public void QuickSort(int left, int right)
        {
            int i = left;
            int j = right;
            int pivot = array[left];

            while (i <= j)
            {
                while (array[i] < pivot)
                {
                    i++;
                }

                while (array[j] > pivot)
                {
                    j--;
                }

                if (i <= j)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }
            }

            if (left < j)
                QuickSort(left, j);

            if (i < right)
                QuickSort(i, right);
        }
        public void ShellSort()
        {
            int n = array.Length;
            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < n; i++)
                {
                    int temp = array[i];
                    int j;
                    for (j = i; j >= gap && array[j - gap] > temp; j -= gap)
                    {
                        array[j] = array[j - gap];
                    }
                    array[j] = temp;
                }
            }
        }
        public void ShakerSort()
        {
            int Left = 0;
            int Right = array.Length - 1;
            int k = 0;
            while (Left < Right)
            {
                for (int i = Left; i < Right; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        swap(ref array[i], ref  array[i + 1]);
                        k = i;
                    }
                }
                Right = k;
                for (int i = Right; i > Left; i--)
                {
                    if (array[i] < array[i - 1])
                    {
                        swap(ref array[i], ref array[i - 1]);
                        k = i;
                    }
                }
                Left = k;
            }
        }
        public void MergeSort()
        {
            int middle = array.Length / 2;
            int left = 0;
            int right = array.Length - 1;
            int leftArrayLength = middle - left + 1;
            int rightArrayLength = right - middle;
            int[] leftTempArray = new int[leftArrayLength];
            int[] rightTempArray = new int[rightArrayLength];
            int i, j;
            for (i = 0; i < leftArrayLength; ++i)
                leftTempArray[i] = array[left + i];
            for (j = 0; j < rightArrayLength; ++j)
                rightTempArray[j] = array[middle + 1 + j];
            i = 0;
            j = 0;
            int k = left;
            while (i < leftArrayLength && j < rightArrayLength)
            {
                if (leftTempArray[i] <= rightTempArray[j])
                {
                    array[k++] = leftTempArray[i++];
                }
                else
                {
                    array[k++] = rightTempArray[j++];
                }
            }
            while (i < leftArrayLength)
            {
                array[k++] = leftTempArray[i++];
            }
            while (j < rightArrayLength)
            {
                array[k++] = rightTempArray[j++];
            }
        }
    }
}
