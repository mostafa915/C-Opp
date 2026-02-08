using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingLast
{
    internal class CurrentAccount : Account
    {
        private double overDraftLimit;
        public double OverDraftLimit {  get => overDraftLimit; set => overDraftLimit = value; }
        public CurrentAccount(double _balance , double _over) : base(_balance)
        {
            OverDraftLimit = _over;
        }

    }
}
