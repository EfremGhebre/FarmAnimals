using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FarmAnimals.Adapter;

namespace FarmAnimals
{
    // Factory design pattern, usually used to provide interface and create
    // objects allowing subclasses to alter the type of objects created  
    
    public class Factory
    {
        // Factory Method Interface
        public abstract class AnimalFactory
        {
            public abstract IAnimal CreateAnimal();
        }

        // Subclass creation from interface
        public class CowFactory : AnimalFactory
        {
            public override IAnimal CreateAnimal()
            {
                return new Animal("Cow", "Moo");
            }
        }

        public class PigFactory : AnimalFactory
        {
            public override IAnimal CreateAnimal()
            {
                return new Animal("Pig", "Oink");
            }
        }

        public class SheepFactory : AnimalFactory
        {
            public override IAnimal CreateAnimal()
            {
                return new Animal("Sheep", "Baa");
            }
        }
    }
}
