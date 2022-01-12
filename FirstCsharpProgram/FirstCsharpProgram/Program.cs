using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCsharpProgram
{
    internal class Program
    {
        static void NhapMang(int n, int[]a)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("Mời bạn nhập phần tử thứ " + i + ": ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        static void XuatMang(int n, int[]a)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.Unicode;

            Console.Write("Mời bạn nhập số lượng phần tử trong mảng: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];

            NhapMang(n, a);
            XuatMang(n, a);
           
          
            Console.ReadKey();
        }
    }
}
