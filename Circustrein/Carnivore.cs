using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{
    public class Carnivore : Animal
    {
        public override bool CanEat(Animal animal)
        {
            return (animal.Size <= Size);
        }
        public Carnivore(AnimalSize size) : base(size)
        {
        }
    }
}
