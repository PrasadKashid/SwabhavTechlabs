using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductApp;

namespace ProductApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Model[] products = new Model[]
            {
                new Model(101, "Bag", 1500),
                new Model(102, "T shirt", 500),
            };

            Console.WriteLine("Enter a product id");
            int productId = int.Parse(Console.ReadLine());
            Model selectedProduct = (Model.PrintDetails(products, productId));
            Console.WriteLine(selectedProduct);
            Console.WriteLine();

            Console.WriteLine("Enter a Product discount");
            double discountPercentage = double.Parse(Console.ReadLine());
            selectedProduct.SetDiscount(discountPercentage);


            Console.WriteLine();
            Console.WriteLine($"Product price after applying {discountPercentage}% discount : " + Model.GetProductDiscount(products, productId));


        }
    }
}