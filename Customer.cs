using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingLast
{
    internal class Customer
    {
        private List<Account> accounts;
        private string fullName;
        private string nationalId;
        private string dateBirth;
        private string id;
        static int count = 0;
        private string GenrateId()
        {
            return $"Acc_Id_{++count}";
        } 
        public string FUllName { get => fullName; set { 
            if(fullName != null) 
                    fullName = value;
            } 
        }
        public string NationalId { get => nationalId; set { 
                if(nationalId != null && nationalId.Length == 14) 
                    nationalId = value;
            } 
        }
        public string DateBirth { get => dateBirth; set => dateBirth = value; }
        public string ID { get => id; }
        public Customer(string _fullName, string _nationalId, string _dateBirth)
        {
            this.fullName = _fullName;
            this.dateBirth = _dateBirth;
            this.id = GenrateId();
            this.nationalId = _nationalId;
        }
        public void AddAccount(string typeofAcc ,double balance , double intersetRate_Or_overDraftLimit)
        {
            if(typeofAcc.ToLower() == "saving")
            {
                accounts.Add(new SavingAccount(balance, intersetRate_Or_overDraftLimit));
            }
            else if(typeofAcc.ToLower() == "current")
            {
                accounts.Add(new CurrentAccount(balance, intersetRate_Or_overDraftLimit));
            }
        }
    }
}
