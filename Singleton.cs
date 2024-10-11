using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FarmAnimals.Adapter;

namespace FarmAnimals
{    
    // This part of code uses Singleton design pattern and
    // ensures that only one instance is created and used in the system 

    public class Singleton
    {
        private static Singleton _instance;
        private List<IAnimal> _animals = new List<IAnimal>();

        private Singleton() { }// A private constructor
        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }
        public void AddAnimal(IAnimal animal, string name)
        {
            _animals.Add(animal);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{name} added to the farm!\n");
            Console.ResetColor();
        }

        public void MakeAllAnimalsSound(IAnimalSound soundSystem)
        {
            if (_animals.Count == 0)
            {
                Console.WriteLine("There are no animals on the farm.");
                return;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Animals on the farm: {_animals.Count} animals. \n");
            Console.ResetColor();

            foreach (var animal in _animals)
            {
                animal.MakeSound(soundSystem);
            }
        }
    }
}

