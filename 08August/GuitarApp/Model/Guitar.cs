using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarApp.Model
{
    public class Guitar
    {
        public string SerialNumber {  get; set; }
        public double Price {  get; set; }

        public GuitarSpecs Spec { get; set; }

        public Guitar(string serialNumber, double price, GuitarSpecs specs)
        {
            SerialNumber = serialNumber;
            Price = price;
            Spec = specs;
        }
    }
}
