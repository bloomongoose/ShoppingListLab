using System;
using System.Collections.Generic;

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

            Console.WriteLine("Welcome to Radeen's Greens!");
            Console.WriteLine("Item\t\tPrice");
            Console.WriteLine("=========================");
            foreach(KeyValuePair<string, double> kvp in menu)
            {
                Console.WriteLine($"{kvp.Key}\t{kvp.Value}");
            }


            //List to store plants ordered
            List<string> plants = new List<string>();
            
            //List to store prices corresponding to plants
            List<double> prices = new List<double>();

        }

        //method to take user input and add name and price to Lists
        
    }
}
