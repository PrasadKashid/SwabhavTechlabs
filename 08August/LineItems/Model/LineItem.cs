using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDiscountApp.Model
{
    public class LineItem
    {
        private int _itemId;
        private int _itemQuantity;
        public Product product { get; set; }

        public LineItem(int itemId, int itemQuantity, Product product)
        {
            _itemId = itemId;
            _itemQuantity = itemQuantity;
            this.product = product;
        }
        public int ItemId
        {
            get { return _itemId; }
            set { _itemId = value; }
        }

        public int ItemQuantity
        {
            get { return _itemQuantity; }
            set { _itemQuantity = value; }
        }

        public double CalculateLineItemCost()
        {
            double totalCost = ItemQuantity * product.CalculateDiscountPrice();
            return totalCost;
        }

    }
}
