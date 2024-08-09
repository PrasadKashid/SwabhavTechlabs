using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StateDesignPattern.GlobalInterface;

namespace StateDesignPattern.Model
{
    internal class DebitNotInserted : IAtm
    {
        public void InsertDebit()
        {
            Console.WriteLine("Atm Not Inserted");
        }
        public void EnterPin() {

            Console.WriteLine("ATM not inserted");
        }

       public void WithdrawMoney() {

            Console.WriteLine("Please insert Debit card first");
        }
    }
}
