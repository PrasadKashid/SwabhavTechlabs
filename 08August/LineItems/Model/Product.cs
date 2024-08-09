using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDiscountApp.Model
{
    public class Product
    {
        private int _productId;
        private string _productName;
        private double _productPrice;
        private double _productDiscountPercent;

        public Product(int id, string name, double price, double percentDiscount)
        {
            _productId = id;
            _productName = name;
            _productPrice = price;
            _productDiscountPercent = percentDiscount;
        }
        public int ProductId { get { return _productId; } set { _productId = value; } }
        public string ProductName { get { return _productName; } set { _productName = value; } }
        public double ProductPrice { get { return _productPrice; } set { _productPrice = value; } }
        public double ProductDiscountPercent { get { return _productDiscountPercent; } set { _productDiscountPercent = value; } }


        public double CalculateDiscountPrice()
        {
            double discountPercent = (_productDiscountPercent / 100);
            double discountedPrice = _productPrice - _productPrice * discountPercent;
            return discountedPrice;
        }

    }
}
