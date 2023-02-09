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
        large = 5,
    }
    public enum Type
    {
        Carnivore, 
        Herbivore
    }
    public class Animal
    {
        private string name;
        public Size size;
        public Type type;
        private static int Animalcount = 0;

      
        public Animal(string name, Size size, Type type)
        {
            this.name = name;
            this.size = size;
            this.type = type;
           
        }
        public Animal(Size size, Type type ) : this("Nameless animal " + Animalcount.ToString(), size, type)
        {
            
        }
        public int IncrementAnimal()
        {
            return Animalcount++;
        }

        public override string ToString()
        {
            return name.ToString() + " , " + size.ToString() + " , " + type.ToString();
        }
    }
}
