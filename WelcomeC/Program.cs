using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeC
{
    public abstract class Item
    {
        private string Name;
        private double Price;
        private int Quantity;

        public static string GetName(Item item) => item.Name;
        public static double GetPrice(Item item) => item.Price;
        public static int GetQuantity(Item item) => item.Quantity;

        public static void SetQuantity(Item item, int newQ)
        {
            item.Quantity = newQ;
        }

        public Item()
        {
            Name = null;
            Price = -1.00;
            Quantity = -1;
        }
        public Item(string n, double p, int q)
        {
            Name = n;
            Price = p;
            Quantity = q;
        }
        public virtual void Sell (int sellCount)
        {
            if (sellCount < 0)
            {
                Console.WriteLine("ERROR: Negative Quantity to Sell, Returning...");
                Console.ReadKey();
                return;
            }

            if (sellCount > Quantity)
            {
                Console.WriteLine("ERROR: Not enough " + Name + "(s) in stock, Returning...");
                Console.ReadKey();
                return;
            }

            Quantity -= sellCount;

            double totalPrice = Price * sellCount;
            string msg = sellCount + " " + Name + "(s) = $" + totalPrice;
            Console.WriteLine(msg);
            Console.WriteLine(Quantity + " " + Name + "(s) remaining");
            Console.ReadKey();
        }
        public virtual void Restock (int restockCount)
        {
            if (restockCount < 0)
            {
                Console.WriteLine("ERROR: Negative Quantity to Restock, Returning...");
                Console.ReadKey();
                return;
            }

            int tempQuant = Quantity;
            Quantity += restockCount;

            string msg = "There were " + tempQuant + " " + Name + "(s) in stock.";
            Console.WriteLine(msg);

            msg = "There are now " + Quantity + " " + Name + "(s) in stock.";
            Console.WriteLine(msg);

            Console.ReadKey();
        }
        public virtual void Info()
        {
            Console.WriteLine(Name);
            Console.WriteLine("$" + Price + " per unit. " + Quantity + " units in stock");
        }
    }
    public class Book : Item
    {
        public Book(): base("Book", -1.00, -1)
        { }
        public Book(string n, double p, int q): base(n, p, q)
        { }
        public override void Sell (int sellCount)
        {
            string tempName = GetName(this);
            double tempPrice = GetPrice(this);
            int tempQuant = GetQuantity(this);

            if (sellCount < 0)
            {
                Console.WriteLine("ERROR: Negative Quantity to Sell, Returning...");
                Console.ReadKey();
                return;
            }

            if (sellCount > tempQuant)
            {
                Console.WriteLine("ERROR: Not enough copies of " + tempName + " in stock, Returning...");
                Console.ReadKey();
                return;
            }

            tempQuant -= sellCount;
            SetQuantity(this, tempQuant);

            double totalPrice = tempPrice * sellCount;
            Console.WriteLine();
            Console.WriteLine("$" + totalPrice + " for " + sellCount + " units of " + tempName);
            Console.WriteLine(tempQuant + " units of " + tempName + " remaining");
            Console.ReadKey();
        }
        public override void Restock(int restockCount)
        {
            string tempName = GetName(this);
            int tempQuant = GetQuantity(this);

            if (restockCount < 0)
            {
                Console.WriteLine("ERROR: Negative Quantity to Restock, Returning...");
                Console.ReadKey();
                return;
            }

            int oldQuant = tempQuant;
            tempQuant += restockCount;
            SetQuantity(this, tempQuant);

            string msg = "There were " + oldQuant + " units of " + tempName + " in stock.";
            Console.WriteLine(msg);

            msg = "There are now " + tempQuant + " units of " + tempName + " in stock.";
            Console.WriteLine(msg);

            Console.ReadKey();
        }
        public override void Info()
        {
            string tempName = GetName(this);
            double tempPrice = GetPrice(this);
            int tempQuant = GetQuantity(this);
            Console.WriteLine(tempName);
            Console.WriteLine("$" + tempPrice + " per unit. " + tempQuant + " units in stock");
        }
    }
    public class Fruit : Item
    {
        public Fruit(): base("Fruit", -1.00, -1)
        { }
        public Fruit(string n, double p, int q) : base(n, p, q)
        { }
        public override void Sell(int sellCount)
        {
            string tempName = GetName(this);
            double tempPrice = GetPrice(this);
            int tempQuant = GetQuantity(this);

            if (sellCount < 0)
            {
                Console.WriteLine("ERROR: Negative Quantity to Sell, Returning...");
                Console.ReadKey();
                return;
            }

            if (sellCount > tempQuant)
            {
                Console.WriteLine("ERROR: Not enough " + tempName + "s in stock, Returning...");
                Console.ReadKey();
                return;
            }

            tempQuant -= sellCount;
            SetQuantity(this, tempQuant);

            double totalPrice = tempPrice * sellCount;
            Console.WriteLine();
            Console.WriteLine("$" + totalPrice + " for " + sellCount + " units of " + tempName);
            Console.WriteLine(tempQuant + " units of " + tempName + " remaining");
            Console.ReadKey();
        }
        public override void Restock(int restockCount)
        {
            string tempName = GetName(this);
            int tempQuant = GetQuantity(this);

            if (restockCount < 0)
            {
                Console.WriteLine("ERROR: Negative Quantity to Restock, Returning...");
                Console.ReadKey();
                return;
            }

            int oldQuant = tempQuant;
            tempQuant += restockCount;
            SetQuantity(this, tempQuant);

            string msg = "There were " + oldQuant + " units of " + tempName + "(s) in stock.";
            Console.WriteLine(msg);

            msg = "There are now " + tempQuant + " units of " + tempName + "(s) in stock.";
            Console.WriteLine(msg);

            Console.ReadKey();
        }
        public override void Info()
        {
            string tempName = GetName(this);
            double tempPrice = GetPrice(this);
            int tempQuant = GetQuantity(this);
            Console.WriteLine(tempName);
            Console.WriteLine("$" + tempPrice + " per unit. " + tempQuant + " units in stock");
        }
    }
    public class Shoe : Item
    {
        public Shoe(): base("Shoe", -1.00, -1)
        { }
        public Shoe(string n, double p, int q): base(n, p, q)
        { }
        public override void Sell(int sellCount)
        {
            string tempName = GetName(this);
            double tempPrice = GetPrice(this);
            int tempQuant = GetQuantity(this);

            if (sellCount < 0)
            {
                Console.WriteLine("ERROR: Negative Quantity to Sell, Returning...");
                Console.ReadKey();
                return;
            }

            if (sellCount > tempQuant)
            {
                Console.WriteLine("ERROR: Not enough " + tempName + " in stock, Returning...");
                Console.ReadKey();
                return;
            }

            tempQuant -= sellCount;
            SetQuantity(this, tempQuant);

            double totalPrice = tempPrice * sellCount;
            Console.WriteLine();
            Console.WriteLine("$" + totalPrice + " for " + sellCount + " units of " + tempName);
            Console.WriteLine(tempQuant + " units of " + tempName + " remaining");
            Console.ReadKey();
        }
        public override void Restock(int restockCount)
        {
            string tempName = GetName(this);
            int tempQuant = GetQuantity(this);

            if (restockCount < 0)
            {
                Console.WriteLine("ERROR: Negative Quantity to Restock, Returning...");
                Console.ReadKey();
                return;
            }

            int oldQuant = tempQuant;
            tempQuant += restockCount;
            SetQuantity(this, tempQuant);

            string msg = "There were " + oldQuant + " units of " + tempName + " in stock.";
            Console.WriteLine(msg);

            msg = "There are now " + tempQuant + " units of " + tempName + " in stock.";
            Console.WriteLine(msg);

            Console.ReadKey();
        }
        public override void Info()
        {
            string tempName = GetName(this);
            double tempPrice = GetPrice(this);
            int tempQuant = GetQuantity(this);
            Console.WriteLine(tempName);
            Console.WriteLine("$" + tempPrice + " per unit. " + tempQuant + " units in stock");
        }
    }

    class Store
    {
        List<Item> inventory = new List<Item>();
        static void Main(string[] args)
        {
            bool truthVal = true;
            string userInput, itemName;
            double itemPrice;
            int userChoice, itemQuant;

            Store s = new Store();

            while (truthVal)
            {
                Console.WriteLine("Welcome to the Store. Please enter a command:");
                // Menu Print
                Console.WriteLine("1. Add new Books to Inventory");
                Console.WriteLine("2. Add new Fruits to Inventory");
                Console.WriteLine("3. Add new Shoes to Inventory");
                Console.WriteLine("4. Sell Items from Inventory");
                Console.WriteLine("5. Restock Items to Inventory");
                Console.WriteLine("6. Access information on Items in Inventory");
                Console.WriteLine("7. Exit Program");
                Console.WriteLine();
                // ReadKey from User
                userInput = Console.ReadLine();
                userChoice = Convert.ToInt32(userInput); // IMPORTANT: Crashes the program if the input cannot be converted to an integer

                if (userChoice == 1) // Add new Books to Inventory
                {
                    Console.WriteLine("What is the name of the Book?");
                    userInput = Console.ReadLine();
                    itemName = userInput;

                    Console.WriteLine("How much does one copy of " + itemName + " cost?");
                    userInput = Console.ReadLine();
                    itemPrice = Convert.ToDouble(userInput);

                    Console.WriteLine("How many copies of " + itemName + " would you like to add to the inventory?");
                    userInput = Console.ReadLine();
                    itemQuant = Convert.ToInt32(userInput);

                    Book b = new Book(itemName, itemPrice, itemQuant);
                    s.inventory.Add(b);
                }
                else if (userChoice == 2) // Add new Fruits to Inventory
                {
                    Console.WriteLine("What is the name of the Fruit?");
                    userInput = Console.ReadLine();
                    itemName = userInput;

                    Console.WriteLine("How much does one unit of " + itemName + " cost?");
                    userInput = Console.ReadLine();
                    itemPrice = Convert.ToDouble(userInput);

                    Console.WriteLine("How many units of " + itemName + " would you like to add to the inventory?");
                    userInput = Console.ReadLine();
                    itemQuant = Convert.ToInt32(userInput);

                    Fruit f = new Fruit(itemName, itemPrice, itemQuant);
                    s.inventory.Add(f);
                }
                else if (userChoice == 3) // Add new Shoes to Inventory
                {
                    Console.WriteLine("What is the name of the Shoe?");
                    userInput = Console.ReadLine();
                    itemName = userInput;

                    Console.WriteLine("How much does one unit of " + itemName + " cost?");
                    userInput = Console.ReadLine();
                    itemPrice = Convert.ToDouble(userInput);

                    Console.WriteLine("How many units of " + itemName + " would you like to add to the inventory?");
                    userInput = Console.ReadLine();
                    itemQuant = Convert.ToInt32(userInput);

                    Shoe shoes = new Shoe(itemName, itemPrice, itemQuant);
                    s.inventory.Add(shoes);
                }
                else if (userChoice == 4) // Sell Items
                {
                    Console.WriteLine("What item would you like to sell?");
                    userInput = Console.ReadLine();

                    int i = 0;
                    int compOutput, sellCount;
                    string tempName, sellInput;

                    foreach (Item item in s.inventory)
                    {
                        tempName = Item.GetName(s.inventory[i]);
                        compOutput = string.Compare(userInput, tempName);
                        if (compOutput == 0)        // output == 0 when the strings are equal
                        {
                            break;                  // break ensures that the position i remains where it needs to be
                        }
                        i++;
                    }

                    // should ensure that strings were equal, if they weren't a break might be needed

                    Console.WriteLine("How many units of " + userInput + " would you like to sell?"); // wanted to use tempName, but wouldn't let me
                    sellInput = Console.ReadLine();
                    sellCount = Convert.ToInt32(sellInput);

                    s.inventory[i].Sell(sellCount);
                }
                else if (userChoice == 5) // Restock Items
                {
                    Console.WriteLine("What item would you like to restock?");
                    userInput = Console.ReadLine();

                    int i = 0;
                    int compOutput, restockCount;
                    string tempName, restockInput;

                    foreach (Item item in s.inventory)
                    {
                        tempName = Item.GetName(s.inventory[i]);
                        compOutput = string.Compare(userInput, tempName);
                        if (compOutput == 0)        // output == 0 when the strings are equal
                        {
                            break;                  // break ensures that the position i remains where it needs to be
                        }
                        i++;
                    }

                    // should ensure that strings were equal, if they weren't a break might be needed

                    Console.WriteLine("How many units of " + userInput + " would you like to restock?"); // wanted to use tempName, but wouldn't let me
                    restockInput = Console.ReadLine();
                    restockCount = Convert.ToInt32(restockInput);

                    s.inventory[i].Restock(restockCount);
                }
                else if (userChoice == 6) // Access information on each item (prints all information)
                {
                    int i = 0;
                    foreach (Item item in s.inventory)
                    {
                        Console.Write("Item {0}. ", i + 1);
                        s.inventory[i].Info();
                        Console.WriteLine();
                        i++;
                    }
                }
                else if (userChoice == 7) // Exit Program
                {
                    truthVal = false;
                    Console.WriteLine("Thank you. Come again.");
                    Console.ReadKey();
                }
                else // Invalid Input
                {
                    Console.WriteLine("ERROR: Invalid Input, Returning...");
                    Console.ReadKey();
                }
                Console.WriteLine(); // Adds whitespace above the menu when reprinting
            }
        }
    }
}
