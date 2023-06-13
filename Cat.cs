using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnInheritance
{
    /* Child Class, Inheritance to Animal Class */
    public class Cat : Animal
    {
        /* Property */
        private string Name { get; set; }

        /* Constructor */
        public Cat(string name)
        {
            this.Name = name;
        }

        /* Method */
        public void Meow ()
        {
            Console.WriteLine("{0} is meowing", this.Name);
        }
    }
}
