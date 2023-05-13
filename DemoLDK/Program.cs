using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLDK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, can2;
            Console.WriteLine("Nhap a:");
            a = double.Parse(Console.ReadLine());

            if (a == 0)
            {
                can2 = Math.Sqrt(a);
                Console.WriteLine($"Can bac 2 cua a : {can2}");

                if (a < 3) {
                    Console.WriteLine("Khong tin can");
                }
            }
            else
            {
                Console.WriteLine("a khong phai so duong");
            }
            
            Console.ReadLine();


        }
    }
}
