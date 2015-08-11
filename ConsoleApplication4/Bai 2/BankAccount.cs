using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.Bai_2
{
    class BankAccount
    {
        private long balance;

        internal BankAccount(long n)
        {
            balance = n;
        }

        internal long Balance
        {
            get { return balance; }
        } 

        internal void withdraw(long money)
        {
            balance = balance + money;
        }

        internal void pay(long money)
        {
            if (balance >= money) 
            {
                balance = balance - money;
                Console.WriteLine("Da rut {0} k", money);
            }
            else
            {
                Console.WriteLine("Da rut {0} k", balance);
                balance = 0;
            }
            Console.WriteLine("Con lai {0} k", balance);
        }
    }
}
