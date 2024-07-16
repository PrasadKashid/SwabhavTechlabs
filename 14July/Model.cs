using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProductApp
{
    internal class Model
    {
        private int _productId;
        private string _productName;
        private double _productPrice;
        private double _productDiscount;

        public Model(int productId, string productName,double productPrice) : this(productId, productName, productPrice, 0) { }

        public Model(int productId, string productName, double productPrice, double productDiscount)
        {
            _productId = productId;
            _productName = productName;
            _productPrice = productPrice;
            _productDiscount = productDiscount;
        }
        public void SetDiscount(double applyDiscount)
        {
            _productDiscount = applyDiscount;
        }

        public static Model FindProduct(Model[] products, int productId) {
            foreach(var product in products)
            {
                if(product._productId == productId)
                {
                    return product;
                }
            }
            return null;
        }

        public static Model PrintDetails(Model[] products, int productId)
        {
            Model product = FindProduct(products, productId);
            if(product!= null)
            {
                return product;
            }
            return null;
        }

        public override string ToString()
        {
            return "ProductId : " + _productId + " Productname : " + _productName + " Product Price " +_productPrice ;
        }

        public static double GetProductDiscount(Model[] products, int productId)
        {
            Model product = FindProduct(products, productId);
            double discountAmount = (product._productDiscount / 100) * product._productPrice;
            double finalDiscountPrice = product._productPrice - discountAmount;
            return finalDiscountPrice;
        }

    }
}
