using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApplication4.Bai_2
{
    class Bai2
    {
        public static void start()
        {
            bool bai2 = true;
            while (bai2)
            {
                Console.WriteLine("Nhap so tien trong tai khoan");
                long money = Convert.ToInt64(Console.ReadLine());

                BankAccount ba = new BankAccount(money);

                ATM atm1 = new ATM(ba, "thu nhat", 200);
                ATM atm2 = new ATM(ba, "thu hai", 100);
                ATM atm3 = new ATM(ba, "thu ba", 100);
                ATM atm4 = new ATM(ba, "thu tu", 200);
                ATM atm5 = new ATM(ba, "thu nam", 300);
                atm1.start();
                atm2.start();
                atm3.start();
                atm4.start();
                atm5.start();

                Thread.Sleep(8000);
                Console.WriteLine();
                Console.WriteLine("SO tien con lai " + ba.Balance);

                Console.ReadLine();
                bai2 = false;
            }
            
        }
    }
}
