using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Sample
{
    class DelegatesSearch
    {
        List<string> items = new List<string>
        {
            "Apples","Bannana", "Mangoes","Tomatoes", "Grapes", "Rin","Soaps"
        };
        Console.WriteLine("Enter the name of the item to find");
        string selected = Console.ReadLine();

        var found = items.Find(delegate (string arg)
        {
            return arg.Contains(selected);
        });

        var selectedItems = items.FindAll(item => item.Contains(selected));
        Console.WriteLine("There are other items with matching letters");
        foreach (var item in selectedItems){
            Console.WriteLine(item);}
}
    }
}
