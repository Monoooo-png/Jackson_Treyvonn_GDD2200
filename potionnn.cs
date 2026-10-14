using System;
using System.Collections.Generic;

class Program
{
    public class Item
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
    }

    static void Main()
    {
        List<Item> inventory = new List<Item>();
        string itemToFind = "Potion";

        // you can find the item directly right here
        Item foundItem = inventory.Find(i => i.Name == itemToFind);

        if (foundItem != null)
        {
            foundItem.Quantity++;
            Console.WriteLine($"We already have a {itemToFind}. New quantity: {foundItem.Quantity}");
        }
        else
        {
            inventory.Add(new Item { Name = itemToFind, Quantity = 1 });
            Console.WriteLine($"Added a brand new {itemToFind} to the list."); //i'll explain more on what i did in the word doc
        }
    }
}