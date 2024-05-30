// C# program to simulate caring for a virtual pet
using System;
using System.Xml.Linq;

namespace VirtualPet        // Namespace declaration
{
    public class Pet        // Class declaration
    {
        public string Type;
        public string Name;
        public int Hunger;
        public int Happiness;
        public int Health;

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
            Console.WriteLine("You feed {0}. Hunger decreases, health slightly increases.", Name);
        }

        // Method to play with the pet
        public void Play()
        {
            Happiness = Math.Min(10, Happiness + 2); // Increase happiness, maximum happiness is 10
            Hunger = Math.Min(10, Hunger + 1); // Slightly increase hunger, maximum hunger is 10
            Console.WriteLine("You play with {0}. Happiness increases, hunger slightly increases.", Name);
        }

        // Method to let the pet rest
        public void Rest()
        {
            Health = Math.Min(10, Health + 2); // Increase health, maximum health is 10
            Happiness = Math.Max(0, Happiness - 1); // Decrease happiness slightly, minimum happiness is 0
            Console.WriteLine("You let {0} rest. Health increases, happiness slightly decreases.", Name);
        }

        // Method to get the current status of the pet
        public string GetStatus()
        {
            return string.Format("{0} - Hunger: {1}, Happiness: {2}, Health: {3}", Name, Hunger, Happiness, Health);
        }

        // Method to pass time
        public void PassTime()
        {
            Hunger = Math.Min(Hunger + 1, 10); // Increase hunger
            Happiness = Math.Max(Happiness - 1, 1); // Decrease happiness
            Console.WriteLine("You passed time for {0}. Hunger increases, happiness slightly decreases.", Name);
        }
    }

    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
        }
    }
}