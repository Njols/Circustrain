using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{
    public class Herbivore : Animal
    {
        public override bool CanEat(Animal animal)
        {
            return false;
        }
        public Herbivore (AnimalSize size) : base(size)
        {
        }
    }
}
