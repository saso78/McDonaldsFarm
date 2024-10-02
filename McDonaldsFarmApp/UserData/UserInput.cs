using McDonaldsFarmApp.BaseData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonaldsFarmApp.UserData
{
    public class UserInput
    {
        private List<FarmAnimal> animals = new List<FarmAnimal>();
        public string GreetUser()
        {
            Console.WriteLine("Hello, What is your name?");
            return Console.ReadLine();
        }

        public bool AskYesNo(string question)
        {
            while (true)
            {
                Console.WriteLine($"{question} (yes/no or y/n):");
                string answer = Console.ReadLine().Trim().ToLower();

                if (answer == "yes" || answer == "y")
                {
                    return true;
                }
                else if (answer == "no" || answer == "n")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter 'yes', 'no', 'y', or 'n'.");
                }
            }
        }
        public Dictionary<string, string> GetAnimalSummary()
        {
            var animalSummary = new Dictionary<string, string>();
            foreach (var animal in animals)
            {
                animalSummary[animal.Name] = animal.Sound;
            }
            return animalSummary;
        }

        public void SayGoodbye(string userName, Dictionary<string, string> animals)
        {
            Console.WriteLine($"{userName}, there were {animals.Count} animals on Old MacDonald's farm.");
            Console.WriteLine("He had:");
            foreach (var animal in animals.Keys)
            {
                Console.WriteLine($"- {animal}");
            }
            Console.WriteLine("Goodbye!");
        }
    }
}
