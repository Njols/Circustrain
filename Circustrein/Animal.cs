using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{
    public enum AnimalSize
    {
        small =1 , medium = 3, big = 5
    }
    public abstract class Animal
    {
        string name;
        public AnimalSize Size { get; }
        public abstract bool CanEat(Animal animal);
        public Animal(AnimalSize size)
        {
            Size = size;
        }
    }
}
