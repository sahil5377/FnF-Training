using System;
using System.Collections.Generic;
using System.Linq;

namespace Sample
{
    class DelegatesSearch
    {
        static void Main()
        {
            List<string> items = new List<string>
            {
                "Apples", "Banana", "Mangoes", "Tomatoes", "Grapes", "Rin", "Soaps"
            };

            Console.WriteLine("Enter the name of the item to find:");
            string selected = Console.ReadLine();

            // Using Find method with delegate
            var found = items.Find(delegate (string arg)
            {
                return arg.Contains(selected);
            });

            if (found != null)
            {
                Console.WriteLine("Found item: " + found);
            }
            else
            {
                Console.WriteLine("Item not found.");
            }

            // Using FindAll method with lambda expression
            var selectedItems = items.FindAll(item => item.Contains(selected));
            if (selectedItems.Count > 0)
            {
                Console.WriteLine("Other items with matching letters:");
                foreach (var item in selectedItems)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("No other items with matching letters found.");
            }
        }
    }
}
