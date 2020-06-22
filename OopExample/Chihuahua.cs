using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace OopExample
{
    public class Chihuahua : Canine
    { 
        public override string Bark()
        {
            return "Squeek!";
        }

        public Chihuahua(string name, string color = "Light brown") : base()
        {

            this.Type = "Chihuahua";
            TailLength = "Short";
            FurLength = "Microscopic";
            Color = color;
            Name = name;
        }
    }
}
