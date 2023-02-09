using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circusclasses
{
    
    public class Wagon
    {
        private int capacity = 10;

        private List<Animal> animals = new List<Animal>();

        public Wagon(Animal animal)
        {
            AddAnimal(animal);
        }
        public void AddAnimal(Animal animal)
        {
            animals.Add(animal);
            capacity -= (int)animal.size;
        }


    }
}
