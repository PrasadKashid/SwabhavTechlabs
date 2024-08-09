using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuitarApp.GlobalEnums;

namespace GuitarApp.Model
{
    public class GuitarSpecs
    {
        public Builder Builder { get; set; }
        public string Model { get; set; }
        public Types Types { get; set; }
        public Wood BackWood { get; set; }
        public Wood TopWood { get; set; }
        public int NumberOfStrings { get; set; }

        public GuitarSpecs(Builder builder, string model, Types types, Wood backwood, Wood topWood, int numberOfStrings)
        {
            Builder = builder;
            Model = model;
            Types = types;
            BackWood = backwood;
            TopWood = topWood;
            NumberOfStrings = numberOfStrings;
        }
    }
}
