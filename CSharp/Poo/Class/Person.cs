using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo.Class
{
    internal class Person : Family
    {
        private string name;

        public int Age { get; set; }


        /// <summary>
        /// Encapsulation idea, private set
        /// </summary>
        public long Cpf { get; private set; }

        /// <summary>
        /// Encapsulation idea
        /// </summary>
        public string Name 
        {
            get
            {
                return name.ToUpper();
            }

            set
            {
                name = value;
            } 
        }

        public Person(string nameFamily, string name, int age) : base(nameFamily)
        {
            Name = name;
            Age = age;
        }

        public void Show()
        {
            Console.WriteLine($"Hi, my name is {Name} of house {NameFamily}, and i have {Age} years old");
        }

        public void SetCpf(long cpf)
        {
            this.Cpf = cpf;
        }


        public override string Characteristics()
        {
            return $"It's new house, the house {NameFamily}";
        }

        public override string NewCharacteristics()
        {
            return "This house has end";
        }
    }
}
