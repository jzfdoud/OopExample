using System;
using System.Collections.Generic;
using System.Text;

namespace OopExample
{
    public class GermanSheperd : Canine
    {

        public override string Bark()
        {
            return "You better run!";
        }

        public GermanSheperd(string name, string color) : base()
        {
            this.Type = "GermanSheperd";
            TailLength = "Long";
            FurLength = "Long";
            Color = color;
            Name = name;
        }
        public GermanSheperd(string name) : this(name, "Brown")
        {
        }
        

    }
}
