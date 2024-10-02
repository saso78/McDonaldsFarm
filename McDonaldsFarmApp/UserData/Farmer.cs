using McDonaldsFarmApp.BaseData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonaldsFarmApp.UserData
{
    internal class Farmer
    {
        private List<FarmAnimal> _farmAnimals;

        public Farmer()
        {
            _farmAnimals = new List<FarmAnimal>();
        }

        public void AddInitialAnimals()
        {
            _farmAnimals.Add(new Cow());
            _farmAnimals.Add(new Dog());
            _farmAnimals.Add(new Cat());
            _farmAnimals.Add(new Duck());
            _farmAnimals.Add(new Pig());
        }

        public void SingSong()
        {
            foreach (var animal in _farmAnimals)
            {
                animal.SingVerse();
            }
        }

        public void AddUserAnimals()
        {
            Console.WriteLine("How many animals would you like to add?");
            if (int.TryParse(Console.ReadLine(), out int numberOfAnimals))
            {
                for (int i = 0; i < numberOfAnimals; i++)
                {
                    Console.WriteLine("Enter the animal's name:");
                    string name = Console.ReadLine();

                    Console.WriteLine("Enter the sound this animal makes:");
                    string sound = Console.ReadLine();

                    _farmAnimals.Add(new UserAnimal(name, sound));
                }
            }
            else
            {
                Console.WriteLine("Invalid number. Please try again.");
            }
        }
        public Dictionary<string, string> GetAnimalSummary()
        {
            var animalSummary = new Dictionary<string, string>();
            foreach (var animal in _farmAnimals)
            {
                animalSummary[animal.Name] = animal.Sound; // Adjust according to your animal object properties
            }
            return animalSummary;
        }
        public void PrintSummary(string userName)
        {
            Console.WriteLine($"{userName}, there were {_farmAnimals.Count} animals on Old MacDonald's farm.");
            Console.WriteLine("He had the following animals:");

            foreach (var animal in _farmAnimals)
            {
                Console.WriteLine($"- {animal.Name}");
            }

            Console.WriteLine("Goodbye!");
        }
    }
}

