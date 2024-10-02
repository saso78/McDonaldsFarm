using McDonaldsFarmApp.BaseData;
using McDonaldsFarmApp.UserData;
using System;
using System.Collections.Generic;

namespace McDonaldsFarmApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Farmer farmManager = new Farmer();
            UserInput userInput = new UserInput();
           
            string userName = userInput.GreetUser();
            if (userInput.AskYesNo($"{userName}, would you like to hear a song?"))
            {
                farmManager.AddInitialAnimals();
                farmManager.SingSong();
                if (userInput.AskYesNo($"{userName}, would you like to add new animals?"))
                {
                    farmManager.AddUserAnimals();
                    farmManager.SingSong();
                }

                Dictionary<string, string> animals = farmManager.GetAnimalSummary();
                userInput.SayGoodbye(userName, animals);
            }
            else
            {
                userInput.SayGoodbye(userName, new Dictionary<string, string>());
            }
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
