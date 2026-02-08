using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingLast
{
    internal class Banks
    {
        private string bankName;
        private int branchCode;
        private List<Customer> customers;
        public string BankName { get { return bankName; } set => bankName = value; }
        public int BranchCode { get { return branchCode; } set { branchCode = value; } }
        public Banks(string _bankName, int _branchCode)
        {
            bankName = _bankName;
            branchCode = _branchCode;
        }
        public void AddCustomer(string _fullName, string _nationalId, string _dateBirth)
        {
            customers.Add(new Customer(_fullName, _nationalId, _dateBirth));
        }
        public void UpdateCustomer(string Id , string _fullName, string _dateBirth) 
        {
            for (var i = 0; i < customers.Count; i++)
            {
                if (customers[i].ID == Id)
                {
                    customers[i].FUllName = _fullName;
                    customers[i].DateBirth = _dateBirth;
                }
            }
        }
    }
}
