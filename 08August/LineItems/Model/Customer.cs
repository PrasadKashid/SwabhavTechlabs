using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDiscountApp.Model
{
    public class Customer
    {
        private int _customerId;
        private string _customerName;

        public List<Order> orders = new List<Order>();
        public Customer(int id, string name, List<Order> orders)
        {
            _customerId = id;
            _customerName = name;

        }

        public int CustomerId { get { return _customerId; } set { _customerId = value; } }
        public string CustomerName { get { return _customerName; } set { _customerName = value; } }


    }
}
