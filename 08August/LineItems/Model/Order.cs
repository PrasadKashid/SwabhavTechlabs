using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDiscountApp.Model
{
    public class Order
    {
        private int _orderId;
        private DateTime _date;
        //public LineItem _lineItem;

        public List<LineItem> lineItems = new List<LineItem>();

        public Order() { }

        public Order(int orderId, DateTime dateTime, List<LineItem> list)
        {
            _orderId = orderId;
            _date = dateTime;
            this.lineItems = list;
        }

        public int OrderId { get { return _orderId; } set { _orderId = value; } }

        public DateTime Date { get { return _date; } set { _date = value; } }

        public double CalculateOrderPrice()
        {
            double orderPrice = 0;
            for (int i = 0; i < lineItems.Count; i++)
            {
                orderPrice += lineItems[i].CalculateLineItemCost();
            }
            return orderPrice;
        }
    }
}
