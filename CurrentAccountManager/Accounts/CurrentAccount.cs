using CurrentAccountManager.Titular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrentAccountManager.Accounts
{
    public class CurrentAccount
    {
        
         public int agency_number { get; set; }
        
        public string account { get; set; }

        private double saldo { get; set; }

        public Client titular { get; set; }

        public void Deposit(double value)
        {
            this.saldo += value;
        }
       
        public bool withdraw(double value)
        {
            if (saldo >= value)
            {
                saldo -= value;
                return true;
            }
            else
                return false;
        }

        public bool Transfer(double value, CurrentAccount destiny)
        {
            if (saldo < value)
            {
                return false;
            }
            else
            {
                saldo -= value;
                destiny.saldo += value;
                return true;
            }

        }

        public void setSaldo(double value)
        {
            if(value < 0)
            {
                return;
            }else
            {
                this.saldo = value;
            }
        }

        public double getSaldo()
        {
            return saldo;
        }

    }
}

