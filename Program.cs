using System;
using System.Collections.Generic;
using static FarmAnimals.Adapter;
using static FarmAnimals.Factory;
using static FarmAnimals.Singleton;

//This application implements Factory, Singleton och Adapter design patterns

namespace FarmAnimals
{
    class Program
    {
        static void Main(string[] args)
        {
            // Getting instance using singleton
            Singleton farm = GetInstance();
            IAnimalSound soundSystem = new AnimalSound();

            // Create animals using factory
            AnimalFactory cowFactory = new CowFactory();
            AnimalFactory pigFactory = new PigFactory();
            AnimalFactory sheepFactory = new SheepFactory();

            // Add animals to the farm
            IAnimal cow = cowFactory.CreateAnimal();
            IAnimal pig = pigFactory.CreateAnimal();
            IAnimal sheep = sheepFactory.CreateAnimal();

            farm.AddAnimal(cow, "Cow");
            farm.AddAnimal(pig, "Pig");
            farm.AddAnimal(sheep, "Sheep");

            // Make all animals sound using adapter
            farm.MakeAllAnimalsSound(soundSystem);
        }
    }
}
