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
            //

            
            string[] fruits = new string[] { "apples", "bananas", "oranges", "grapes", "strawberries", "blueberries" };
            string[] fruitAmount = new string[6];

            Fruit[] foods = new Fruit[6];

            Fruit p1 = new Fruit();

            for (int foodIndex = 0; foodIndex < foods.Length; foodIndex++)
            {
                foods[foodIndex] = new Fruit(fruits[foodIndex]);
                foods[foodIndex].price = 2;
            }


            int fruitIndex = 0;

            foreach (Fruit food in foods)
            {
                Console.WriteLine($"You have {money} dollars.");
                Console.WriteLine($"Do you want to buy {food.name} for {food.price} dollars? (yes/no)");
                string input = Console.ReadLine().ToLower();

            if (money < food.price)
                {
                    Console.WriteLine($"You don't have enough money to buy {food.name}.");
                }
            else
                if (input == "yes")
                {
                    fruitAmount[fruitIndex] = food.name;
                    fruitIndex++;
                    Console.WriteLine($"You bought {food.name} for {food.price} dollars.");
                    money -= food.price;
                }
                else
                {
                    Console.WriteLine($"You chose not to buy {food.name}.");
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

