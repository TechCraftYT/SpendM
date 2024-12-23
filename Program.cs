//Made by 
// x2Beef Coding Productions
// Made with love
//


using System;
using System.Collections.Generic;

class Game
{
    // Player's money and inventory
    private double money = 100.0; // Starting money
    private List<string> inventory = new List<string>();

    // Display the current status of the game
    private void DisplayStatus()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the SpendM");
        Console.WriteLine("In this game you can work to earn money and spend it!");
        Console.WriteLine("====================================");
        Console.WriteLine($"Current Money: ${money}");
        Console.WriteLine("Inventory: " + (inventory.Count > 0 ? string.Join(", ", inventory) : "Nothing"));
        Console.WriteLine("====================================");
        Console.WriteLine("What would you like to do?");
        Console.WriteLine("1. Work (Earn money)");
        Console.WriteLine("2. Buy Coffee ($5)");
        Console.WriteLine("3. Buy Upgrade ($20)");
        Console.WriteLine("4. Quit");
    }

    // Action for working (earning money)
    private void Work()
    {
        double earned = 10.0; // Earn $10 by working
        money += earned;
        Console.WriteLine($"You worked and earned ${earned}. Current Money: ${money}");
        Pause();
    }

    // Action for buying coffee
    private void BuyCoffee()
    {
        if (money >= 5)
        {
            money -= 5;
            inventory.Add("Coffee");
            Console.WriteLine("You bought a coffee! Coffee added to your inventory.");
        }
        else
        {
            Console.WriteLine("Not enough money to buy coffee.");
        }
        Pause();
    }

    // Action for buying an upgrade
    private void BuyUpgrade()
    {
        if (money >= 20)
        {
            money -= 20;
            inventory.Add("Upgrade");
            Console.WriteLine("You bought an upgrade! Upgrade added to your inventory.");
        }
        else
        {
            Console.WriteLine("Not enough money to buy an upgrade.");
        }
        Pause();
    }

    // Helper function to pause and wait for user input
    private void Pause()
    {
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

    // Main method for running the game
    public void Run()
    {
        bool isRunning = true;
        while (isRunning)
        {
            DisplayStatus();

            // User input for action
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Work();
                    break;
                case "2":
                    BuyCoffee();
                    break;
                case "3":
                    BuyUpgrade();
                    break;
                case "4":
                    isRunning = false;
                    Console.WriteLine("Thanks for playing!");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please choose a valid action.");
                    Pause();
                    break;
            }
        }
    }
}

class Program
{
    static void Main()
    {
        Game game = new Game();
        game.Run();
    }
}
