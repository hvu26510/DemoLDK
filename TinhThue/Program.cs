using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhThue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double thuNhap, thue = 0;

            Console.WriteLine("Nhap vao thu nhap ( dv tr dong)");

            thuNhap = double.Parse(Console.ReadLine());

            if (thuNhap > 0 && thuNhap < 9)
            {
                thue = 0;
            }
            else if (thuNhap >= 9 && thuNhap < 15)
            {
                thue = thuNhap * 0.1;
            }
            else if (thuNhap >= 15 && thuNhap < 30)
            {
                thue = thuNhap * 0.15;
            }
            else if (thuNhap >= 30)
            {
                thue = thuNhap * 0.2;
            }


            Console.WriteLine($"Thue thu nhap : {thue}");

            Console.ReadLine();

        }
    }
}
