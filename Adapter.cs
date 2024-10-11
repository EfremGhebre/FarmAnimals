using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmAnimals
{
    // Adapter design pattern allows incompatible
    // objects work together, in this case Animal and IAnimalSound

    public class Adapter
    {
        // Adapter Interface (sound system that interacts with animals)
        public interface IAnimalSound
        {
            void PlaySound(string sound);
        }

        // Adapter Implementation (adapting animal sounds to the sound system)
        public class AnimalSound : IAnimalSound
        {
            public void PlaySound(string sound)
            {
                Console.WriteLine($"The sound system plays: {sound}");
            }
        }

        // Animal Interface
        public interface IAnimal
        {
            string AnimalType { get; }
            void MakeSound(IAnimalSound soundSystem);
        }

        // Animal Class (adapting to the sound system)
        public class Animal : IAnimal
        {
            public string AnimalType { get; private set; }
            private string _sound;

            public Animal(string animalType, string sound)
            {
                AnimalType = animalType;
                _sound = sound;
            }

            public void MakeSound(IAnimalSound soundSystem)
            {
                soundSystem.PlaySound(_sound);
            }
        }


        
    }
}
