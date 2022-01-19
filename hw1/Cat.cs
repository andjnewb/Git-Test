using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1
{
    public class Cat
    {
        private string name;

        public Cat()
        {
            name = "Steve";
        }

        public Cat(string n)
        {
            name = n;
        }

        public void printCat()
        {
            Console.WriteLine("This cat's name is " + name);
        }
    }
}
