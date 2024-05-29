// C# program to print Hello World!
using System;
using System.Xml.Linq;

//namespace declaration
namespace HelloWorld
{
    // Class declaration
    class Program
    {
        // Main method
        static void Main(String[] args)
        {
            // Statement
            // Printing Hello World!
            string firstName = "John";
            string surname = "Nwabuoku";
            Console.WriteLine("Hello {0} {1}. ", firstName, surname );
            Console.WriteLine("Hello Worldguyuyfgui!");
            int a = 'a' + 1;
            Console.WriteLine(a);
        }

        static void Arr(String[] args)
        {
            // declares an Array of integers.
            intil intArray;
            // allocating memory for 5 integers.
            intArray = new int[5];
            // initialize the first elements of the array
            intArray[0] = 10; 4
            // initialize the second elements of the array
            intArray[1] = 20;
            // so on..
            intArray[2] = 30;
            intArray[3] = 40;
            intArray[4] = 50;
            // accessing theelements using for loop
            
            Console.WriteLine();
        }
    }
}







using System;

public class Pet
{
    private string type;
    private string name;
    private int hunger;
    private int happiness;
    private int health;

    // Constructor
    public Pet(string type, string name)
    {
        this.type = type;
        this.name = name;
        this.hunger = 5; // Default value
        this.happiness = 5; // Default value
        this.health = 5; // Default value
    }

    // Method to feed the pet
    public void Feed()
    {
        hunger = Math.Max(0, hunger - 2); // Decrease hunger, minimum hunger is 0
        health = Math.Min(10, health + 1); // Slightly increase health, maximum health is 10
        Console.WriteLine("You feed {0}. Hunger decreases, health slightly increases.", name);
    }

    // Method to play with the pet
    public void Play()
    {
        happiness = Math.Min(10, happiness + 2); // Increase happiness, maximum happiness is 10
        hunger = Math.Min(10, hunger + 1); // Slightly increase hunger, maximum hunger is 10
        Console.WriteLine("You play with {0}. Happiness increases, hunger slightly increases.", name);
    }

    // Method to let the pet rest
    public void Rest()
    {
        health = Math.Min(10, health + 2); // Increase health, maximum health is 10
        happiness = Math.Max(0, happiness - 1); // Decrease happiness slightly, minimum happiness is 0
        Console.WriteLine("You let {0} rest. Health increases, happiness slightly decreases.", name);
    }

    // Method to get the current status of the pet
    public string GetStatus()
    {
        return string.Format("{0} - Hunger: {1}, Happiness: {2}, Health: {3}", name, hunger, happiness, health);
    }
}