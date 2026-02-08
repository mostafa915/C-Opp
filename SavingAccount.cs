using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingLast
{
    internal class SavingAccount : Account
    {
        private double intersetRate;
        public double IntersetRate { get => intersetRate; set => intersetRate = value; }
        public SavingAccount(double _balance, double inter) : base(_balance)
        {
            IntersetRate = inter;
        }
        public double CalaculateInterset()
        {
            double Interset = intersetRate * balance;
            balance += Interset;
            return Interset;
        }

    }
}
