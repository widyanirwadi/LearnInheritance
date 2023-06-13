using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnInheritance
{
    /* Child Class, Inheritance to Animal Class */
    public class Dog : Animal
    {
        private string Name { get; set; }

        /* Constructor */
        public Dog(string name)
        {
            this.Name = name;
        }

        /* Method */
        public void Bark()
        {
            Console.WriteLine("{0} is Barking", this.Name);
        }
    }
}
