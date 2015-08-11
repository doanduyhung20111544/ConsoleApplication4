using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication4.Bai_1;
using ConsoleApplication4.Bai_2;
namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                int n;
                Console.WriteLine("Nhap so de chon bai");
                n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1: Bai1.start();
                        break;

                    case 2: Bai2.start();
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
