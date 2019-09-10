using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace ModelLib
{
    public class Car
    {

        public string Model { get; set; }
        public string Color { get; set; }
        public string regNummer { get; set; }


        public Car()
        {
        }

        public Car(string model, string color, string regNummer)
        {
            Model = model;
            Color = color;
            this.regNummer = regNummer;
        }


        public override string ToString()
        {
            return Model +" "+ Color +" "+ regNummer;
        }

    }
}
