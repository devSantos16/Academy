using Poo.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo.Class
{

    internal abstract class Family : IFamily
    {
        public string NameFamily { get; set; }

        
        // Polymorphism
        public virtual string Characteristics()
        {
            return $"The house {NameFamily} is crazy.";
        }

        // Abstract
        public abstract string NewCharacteristics();

        // Interface
        public void SayHello()
        {
            Console.WriteLine("Hello");
        }

        public Family(string nameFamily)
        {
            NameFamily = nameFamily;
        }
    }
}
