using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3TaskAccount
{
    class Account
    {
        private String accname;
        private String acid;
        private int balance;

        public string AccName
        {
            get { return accname; }
            set { accname = value; }
        }
        public string AcId
        {
            get { return acid; }
            set { acid = value; }
        }
        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }


        public Account(string accname, string acid, int balance)
        {
            this.accname = accname;
            this.acid = acid;
            this.balance = balance;
           
        }

        public int Deposit(int amount)
        {
            balance = balance + amount;
            return balance;
        }

        public int Withdraw(int amount)
        {
            balance = balance - amount;
            return balance;
            
            
        }

        public void ShowInfo()
        {
            Console.WriteLine("Account Name :" + accname);
            Console.WriteLine("Account ID :" + acid);
            Console.WriteLine("Balance :" + balance);
        }

        static void Main(string[] args)
        {
            Account a1 = new Account("Pranta", "18-36233-1", 20000);
            Console.WriteLine();
            Console.WriteLine("Initially :");
            a1.ShowInfo();
            a1.Withdraw(10000);
            Console.WriteLine();
            Console.WriteLine("After Withdraw :");
            a1.ShowInfo();
            Console.WriteLine();
            Console.WriteLine("After Deposit :");
            a1.Deposit(40000);
            a1.ShowInfo();


        }
    }
}
