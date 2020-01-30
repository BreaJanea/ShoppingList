using System;
using System.Collections.Generic;

namespace ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            string userContinue;
            double total = 0;

            List<string> shoppingCart = new List<string>();
            List<double> totalOrder = new List<double>();

            Console.WriteLine("Welcome to Brea's Shoe Store!");

            do
            {
                Console.WriteLine("\n\t\tSHOE" + "\t\tPRICE");
                Console.WriteLine("\t\t=====================");

                Dictionary<string, double> menuItems = new Dictionary<string, double>();
                menuItems["Vans"] = 40;
                menuItems["Yeezys"] = 420;
                menuItems["Adidas"] = 90;
                menuItems["Nike"] = 150;
                menuItems["New Balance"] = 60;
                menuItems["Doc Martens"] = 160;
                menuItems["Filas"] = 70;
                menuItems["Jordans"] = 200;

                foreach (KeyValuePair<string, double> kvPair in menuItems)
                {
                    Console.WriteLine($"{kvPair.Key,20} \t\t${kvPair.Value}");
                }

                Console.Write("\nWhich shoe would you like to order?: ");
                string input = Console.ReadLine();

                while (!menuItems.ContainsKey(input))
                {
                    Console.Write("\nSorry, we don't have those shoes. Please try again. ");
                    input = Console.ReadLine();
                }

                Console.WriteLine($"Adding {input} to cart at ${menuItems[input]}.");

                shoppingCart.Add(input);
                totalOrder.Add(menuItems[input]);
                total += menuItems[input];

                Console.Write("Would you like to order anything else? (y/n): ");
                userContinue = Console.ReadLine();

                if (userContinue == "n")
                {
                    Console.WriteLine("\n\nThanks for your order!\nHere's what you got: ");
                    Console.WriteLine("\n\t\tSHOE" + "\t\tPRICE");
                    Console.WriteLine("\t\t=====================");

                    for (int i = 0; i < shoppingCart.Count; i++)
                    {
                        Console.WriteLine($"{shoppingCart[i],20} \t\t${totalOrder[i]}");
                    }

                    Console.WriteLine($"\nAverage price per shoe in order was ${total / totalOrder.Count}");
                }

            } while (userContinue.ToLower() == "y");
        }
    }
}