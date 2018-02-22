using System;
using System.Collections.Generic;

namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a Menu reference object
            Menu breakfastMenu = new Menu("Breakfast Menu", 1);

            //Add waffle breakfast as menu item to breakfast menu
            Dictionary<string, string> waffleBreakfast = new Dictionary<string, string>() { { "waffles", "blueberry syrup and butter over waffles" } };
            int testId = breakfastMenu.AddMenuItem(1000, waffleBreakfast, 5.99, "breakfast", "new");

            //replace breakfast menu items with testId
            breakfastMenu.NumberOfItems = testId;
            Console.WriteLine(breakfastMenu.NumberOfItems);
            Console.ReadLine();
        }
    }

    public class Menu
    {
        List<string> menuItems = new List<string>() { "waffle breakfast" };

        public string Name { get; }
        public int NumberOfItems { get; set; }
        public List<string> MenuItems { get; }
        public string LastUpdated { get; }

        public Menu(string name, int numberOfItems)
        {
          
            Name = name;
            NumberOfItems = numberOfItems;
            MenuItems = menuItems;
            LastUpdated = DateTime.Now.ToString("MM/dd/yyyy");
        }

        public override string ToString()
        {
            return Name + " (Number of Items: " + NumberOfItems + ", Menu Items: " + MenuItems + ", Last Updated: " + LastUpdated + ")";
        }

        public int AddMenuItem(int menuItemId, Dictionary<string, string> nameDescription, double price, string category, string newOrNot)
        {
            MenuItem waffleBreakfast = new MenuItem(menuItemId, nameDescription, price, category, newOrNot);

            //return 
            return waffleBreakfast.MenuItemId;

        }
    }

    public class MenuItem
    {
        public int MenuItemId { get; set; }
        public Dictionary<string, string> NameDescription { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
        public string NewOrNot { get; set; }

        public MenuItem(int menuItemId, Dictionary<string, string> nameDescription, double price, string category, string newOrNot)
        {
            MenuItemId = menuItemId;
            NameDescription = nameDescription;
            Price = price;
            Category = category;
            NewOrNot = NewOrNot;
        }

    }
}

