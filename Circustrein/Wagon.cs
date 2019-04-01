using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{
    public class Wagon
    {
        List<Animal> animals = new List<Animal>();
        public List<Animal> Animals
        {
            get { return animals; }
        }
        public void addAnimal (Animal animal)
        {
            animals.Add(animal);
        }
        public int Occupancy
        {
            get {
                int addedValue = 0;
                foreach (Animal animal in animals)
                {
                    addedValue += (int)animal.Size;
                }
                return addedValue;
            }
        }
        public Wagon (Animal animal)
        {
            animals.Add(animal);
        }
        public Wagon ()
        {

        }
        public override string ToString()
        {
            return "wagon " + Occupancy.ToString() + " /10";
        }
        public bool CanAddAnimalToWagon(Animal animal)
        {
            if (Occupancy + (int)animal.Size <= 10)
            {
                List<Animal> coolAnimals = new List<Animal>();
                coolAnimals.Add(animal);
                coolAnimals.AddRange(Animals);
                foreach (Animal Animal in coolAnimals)
                {
                    foreach (Animal _animal in coolAnimals)
                    {
                        if (Animal.CanEat(_animal))
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
            return false;
        }
    }
}
