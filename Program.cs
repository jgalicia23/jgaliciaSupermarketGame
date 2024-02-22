using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketGame
{

    class Program
    {

        static void Main(string[] args)
        {
            Random rnd = new Random();
            int money = rnd.Next(1, 21);

            Console.WriteLine("You are at the supermarket.");
            Console.WriteLine("You want to make a fruit salad. What would you like to buy?");
            Console.WriteLine($"You have {money} dollars.");

            
            string[] fruits = new string[] { "apples", "bananas", "oranges", "grapes", "strawberries", "blueberries" };
            string[] fruitAmount = new string[6];

            Fruit[] foods = new Fruit[6];

            Fruit p1 = new Fruit();

            for (int foodIndex = 0; foodIndex < foods.Length; foodIndex++)
            {
                foods[foodIndex] = new Fruit(fruits[foodIndex]);
            }


            int fruitIndex = 0;

            foreach (var fruit in fruits)
            {
                Console.WriteLine($"Do you want to buy {fruit}? (yes/no)");
                string input = Console.ReadLine().ToLower();

                if (input == "yes")
                {
                    fruitAmount[fruitIndex] = fruit;
                    fruitIndex++;
                    Console.WriteLine($"You bought {fruit}.");
                }
                else
                {
                    Console.WriteLine($"You chose not to buy {fruit}.");
                }
            }
            Console.WriteLine("\nYou bought the following fruits:");
            foreach (var fruit in fruitAmount)
            {
                Console.WriteLine(fruit);
            }

            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}

