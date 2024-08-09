using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern.GlobalInterface
{
    public interface IAtm
    {
        public void InsertDebit();
        public void EnterPin();
        public void WithdrawMoney();


    }
}
