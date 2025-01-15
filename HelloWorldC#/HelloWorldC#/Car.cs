using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldC_
{
    public class Car
    {
        public string make;
        string model;
        public int year;
        public string VIN;
        public string exteriorColor;
        public string interiorColor;
        public Car(string make, string model, int year, string VIN, string exteriorColor, string interiorColor)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.VIN = VIN;
            this.exteriorColor = exteriorColor;
            this.interiorColor = interiorColor;
        }
    }
}
