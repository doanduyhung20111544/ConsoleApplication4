using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApplication4.Bai_2
{
    class ATM
    {
        
        private BankAccount ba;
        private string name;
        private long money;

        internal long Money
        {
            get { return money; }
        } 

        internal ATM(BankAccount sba, string sname, long smoney)
        {
            ba = sba;
            name = sname;
            money = smoney;
        }

        internal void start()
        {
            Thread t = new Thread(new ThreadStart(() =>
            {
                for (int i = 0; i < 7; i++)
                {
                    Thread.Sleep(1000);
                    if (i < 2)
                    {
                        Console.WriteLine("ATM {0} bat dau rut.......",name);
                        continue;
                    }                    
                    if (ba.Balance == 0)
                    {
                        Console.WriteLine("ATM "+name+": tai khoan da het tien");
                        break;
                    }
                    if (ba.Balance >= money)
                    {
                        Console.Write("ATM " + name+" ");
                        ba.pay(money);
                    }
                    else
                    {
                        Console.Write("ATM " + name+" ");
                        ba.pay(ba.Balance);
                    }
                    if (i == 6)
                    {
                        Console.WriteLine("ATM " + name + " da rut xong");
                    }
                }
            }));
            t.Start();
        }
    }
}
