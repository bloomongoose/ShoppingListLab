using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingListLab
{
    class Program
    {
        static void Main(string[] args)
        {
            //Generic Collection holding the menu of items
            Dictionary<string, double> menu = new Dictionary<string, double>();
            menu.Add("Dragonfruit", 9.99);
            menu.Add("Juniper Bonsai", 29.99);
            menu.Add("Spider Plant", 10.99);
            menu.Add("Devil's Ivy", 14.99);
            menu.Add("English Ivy", 12.99);
            menu.Add("Aloe Vera", 11.99);
            menu.Add("Snake Plant", 14.99);
            menu.Add("Philodendron", 7.99);

            //List to store cart ordered
            List<string> cart = new List<string>();

            //List to store prices corresponding to plants
            List<double> prices = new List<double>();

            Console.WriteLine("Welcome to Radeen's Greens!");

            bool runProgram = true;

            while (runProgram)
            {
                //Menu display
                displayMenu(menu);
                string result = getItem(menu);
                Console.WriteLine($"You bought a {result} for ${menu[result]:0.00}");

                //storing items in cart
                cart.Add(result);
                prices.Add(menu[result]);

                //ask if continue
                runProgram = getContinue();
            }
            //display receipt
            displayReceipt(cart, prices);

        }

        //method to ask if they wish to continue or not
        static bool getContinue()
        {
            bool result = true;
            while (true)
            {
                Console.WriteLine("Would you like to continue? y/n");
                string choice = Console.ReadLine().ToLower();
                if(choice == "y")
                {
                    result = true;
                    break;
                }
                else if (choice == "n")
                {
                    result = false;
                    break;
                }
                else
                {
                    Console.WriteLine("That wasn't a valid choice.");
                }
            }
            return result;
        }

        //method to display the reciept for purchase
        static void displayReceipt(List<string> cart, List<double> prices)
        {
            Console.WriteLine("This is your receipt:");
            Console.WriteLine();
            for(int i = 0; i<cart.Count; i++)
            {
                Console.WriteLine($"{cart[i],-25}{prices[i].ToString("0.00"),-25}");
            }
            //average price display
            Console.WriteLine($"Average price of cart: {prices.Average():0.00}");
        }

        //method to get item from user
        static string getItem(Dictionary<string, double> menu)
        {
            string result = "";
            while (true)
            {
                Console.WriteLine("Please type the name of the item you want to buy.");
                result = Console.ReadLine();
                //returns true if key exists
                if (menu.ContainsKey(result))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("That's not one of the items. Try again");
                }
            }
            return result;
        }

        //method to display menu
        static void displayMenu(Dictionary<string, double> menu)
        {
            Console.WriteLine(string.Format($"{"Item",-25}{"Price",-25}"));
            Console.WriteLine("================================");
            foreach (KeyValuePair<string, double> kvp in menu)
            {
                Console.WriteLine($"{kvp.Key,-25}{kvp.Value.ToString("0.00"),-25}");
            }
        }
    }
}
