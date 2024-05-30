// C# program to simulate caring for a virtual pet
using System;
using System.Transactions;

namespace VirtualPet        // Namespace declaration
{
    public class Pet        // Class declaration
    {
        public string Type { get; set; }
        public string Name { get; set; }   
        public int Hunger { get; set; }
        public int Happiness { get; set; }
        public int Health { get; set; }

        // Constructor
        public Pet(string type, string name)
        {
            Type = type;
            Name = name;
            Hunger = 5; // Default value
            Happiness = 5; // Default value
            Health = 5; // Default value
        }

        // Method to feed the pet
        public void Feed()
        {
            Hunger = Math.Max(0, Hunger - 2); // Decrease hunger, minimum hunger is 0
            Health = Math.Min(10, Health + 1); // Slightly increase health, maximum health is 10
            Console.WriteLine($"\nYou fed {Name}. Hunger: {Hunger}(decreased), Health: {Health}(slightly increased).");
        }

        // Method to play with the pet
        public void Play()
        {
            Happiness = Math.Min(10, Happiness + 2); // Increase happiness, maximum happiness is 10
            Hunger = Math.Min(10, Hunger + 1); // Slightly increase hunger, maximum hunger is 10
            Console.WriteLine($"\nYou played with {Name}. Happiness: {Happiness}(increased), Hunger: {Hunger}(slightly increased).");
        }

        // Method to let the pet rest
        public void Rest()
        {
            Health = Math.Min(10, Health + 2); // Increase health, maximum health is 10
            Happiness = Math.Max(0, Happiness - 1); // Decrease happiness slightly, minimum happiness is 0
            Console.WriteLine("\nYou let {0} rest. Health: {1} (increased), Happiness: {2} (slightly decreased).", Name, Health, Happiness);
        }

        // Method to get the current status of the pet
        public void GetStatus()
        {
            Console.WriteLine($"\nStatus of {Name} the {Type}:\nHunger: {Hunger} | Happiness: {Happiness} | Health: {Health}");
        }

        // Method to pass time
        public void PassTime()
        {
            Hunger = Math.Min(10, Hunger + 1); // Increase hunger
            Happiness = Math.Max(1, Happiness -1); // Decrease happiness
            Health = Math.Min(10, Health - 1); //Health decreases slightly
            Console.WriteLine("You passed time for {0}. Hunger {1} increased, happiness {2} slightly decreased, Health {3} decreased.", Name, Hunger, Happiness, Health);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hi, Please enter your name: ");
            string userName = Console.ReadLine();

            Console.WriteLine("Hello {0}:), Welcome to your Pet Care Simulation! \n", userName);
            
            Console.Write("Choose your type of pet (Cat, Dog, Rabbit, Hamster): ");
            string petType = Console.ReadLine();

            Console.Write("Give your pet a name: ");
            string petName = Console.ReadLine();
            

            Pet myPet = new Pet(petType, petName);

            Console.WriteLine($"\nYou now have a {myPet.Type} named {myPet.Name}!  \n /\\_/\\  \r\n( o.o ) \r\n > ^ <");

            bool exit = false;

            for (; !exit;)
            {
                Console.WriteLine("\nHow would you like to care for {0}?", petName);
                Console.WriteLine("1. Feed");
                Console.WriteLine("2. Play");
                Console.WriteLine("3. Rest");
                Console.WriteLine("4. Check Status");
                Console.WriteLine("5. Pass Time");
                Console.WriteLine("6. Exit");
                Console.Write("\nEnter your choice: ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    myPet.Feed();
                }
                else if (choice == "2")
                {
                    myPet.Play();
                }
                else if (choice == "3")
                {
                    myPet.Rest();
                }
                else if (choice == "4")
                {
                    myPet.GetStatus();
                }
                else if (choice == "5")
                {
                    myPet.PassTime();
                }
                else if (choice == "6")
                {
                    Console.WriteLine("Goodbye!");
                    exit = true;
                }
                else
                {
                    Console.WriteLine("Invalid choice, please try again.");
                }
            }
        }
    }
}