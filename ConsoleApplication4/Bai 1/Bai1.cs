using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ConsoleApplication4.Bai_1
{
    class Bai1
    {
        public static void start()
        {
            Clock c = new Clock();
            bool bai1 = true;
            while (bai1)
            {
                Console.WriteLine("Nhap so: \n1: start, \n2: start(count), \n3: stop, \n4: IsRunning, \n5: exit");
                int n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1: c.start();
                        break;
                    case 2: c.start(10);
                        break;
                    case 3: c.stop();
                        break;
                    case 4: Console.WriteLine("Trang thai Thread: "+c.IsRunning);
                        break;
                    case 5:
                        {
                            c.stop();
                            bai1 = false;
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
