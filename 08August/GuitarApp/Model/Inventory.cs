using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuitarApp.GlobalEnums;

namespace GuitarApp.Model
{
    public class Inventory
    {
        private List<Guitar> GuitarList = new List<Guitar>();

        public void AddGuitar(String number, double Price, GuitarSpecs specs)
        {
            GuitarList.Add(new Guitar(number, Price, specs));
        }
        public Guitar getGuitar(String serialNumber)
        {
            foreach (var guitar in GuitarList)
            {
                if (guitar.SerialNumber == serialNumber)
                {
                    return guitar;
                }
            }
            return null;
        }

        public List<Guitar> SearchGuitar(GuitarSpecs searchSpec)
        {
            List<Guitar> matchingGuitars = new List<Guitar>();
            foreach (var guitar in GuitarList)
            {
                if ((searchSpec.Builder == Builder.Any || guitar.Spec.Builder == searchSpec.Builder) &&
                    (searchSpec.Model == null || guitar.Spec.Model == searchSpec.Model) &&
                    (searchSpec.Types == null || guitar.Spec.Types == searchSpec.Types) &&
                    (searchSpec.BackWood == null || guitar.Spec.BackWood == searchSpec.BackWood) &&
                    (searchSpec.TopWood == null || guitar.Spec.TopWood == searchSpec.TopWood) &&
                    (searchSpec.NumberOfStrings == null || guitar.Spec.NumberOfStrings == searchSpec.NumberOfStrings))
                {
                    matchingGuitars.Add(guitar);
                }
            }
            return matchingGuitars;
        }

    }
}
