using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTBac2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta;

            Console.WriteLine("Nhap a: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap b: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap c: ");
            c = double.Parse(Console.ReadLine());

            if (a != 0)
            {
                // Giai PT bac 2
                delta = Math.Pow(b, 2) - 4 * a * c;

                if (delta < 0)
                {
                    Console.WriteLine("Vo Nghiem");
                }
                else if (delta == 0)
                {
                    Console.WriteLine($"X = {-b / (2 * a)}");
                }
                else
                {
                    Console.WriteLine("Hai Nghiem");
                    Console.WriteLine($"X = {(-b + Math.Sqrt(delta)) / (2 * a)}");
                    Console.WriteLine($"X = {(-b - Math.Sqrt(delta)) / (2 * a)}");
                }
            }
            else
            {
                // a = 0, giai PT bac nhat
                if(b==0)
                {
                    if(c==0)
                    {
                        Console.WriteLine("Vo so nghiem");
                    }
                    else
                    {
                        Console.WriteLine("Vo Nghiem");
                    }
                }
                else
                {
                    Console.WriteLine($"x = {-c / b}");
                }
            }

            

            Console.ReadLine();

        }
    }
}
