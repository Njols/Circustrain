using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{
    public class Train
    {
        List<Wagon> wagons = new List<Wagon>();
        public void addWagon(Wagon wagon)
        {
            wagons.Add(wagon);
        }
        public List<Wagon> Wagons
        {
            get { return wagons; }
        }
        public void addGroupOfAnimals(List<Animal> animals)
        {
            List<Animal> plantEaters = new List<Animal>();
            foreach (Animal animal in animals)
            {
                if (animal is Carnivore)
                {
                    coolAddAnimalToWagon(animal);
                }
                else
                {
                    plantEaters.Add(animal);
                }
            }
            List<Animal> sortedPlantEaters = plantEaters.OrderByDescending(a => a.Size).ToList();
            foreach (Animal animal in sortedPlantEaters)
            {
                coolAddAnimalToWagon(animal);
            }
        }
        public void coolAddAnimalToWagon(Animal animal)
        {
            foreach (Wagon wagon in wagons)
            {
                if (wagon.TryToAddAnimal(animal))
                {
                    return;
                }
            }
            addWagon(new Wagon(animal));
        }
    }
}
