using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Circusclasses
{
    public enum Size
    {
        small = 1,
        medium = 3,
        big = 5,
    }
    public enum Type
    {
        Carnivore, 
        Herbivore
    }
    public class Animal
    {
        public Size size { get; set; }
        public Type type { get; set; }

        public Animal(Size size, Type type)
        {
            this.size = size;
            this.type = type;   
        }

        public override string ToString()
        {
            return "The animal is a " + type.ToString() + " and is of " + size + " size";
        }
    }
}
