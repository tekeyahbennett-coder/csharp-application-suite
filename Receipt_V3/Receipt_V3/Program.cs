using System;

using System;

class Program
{
    static void Main(string[] args)
    {
        string[,] items = new string[100, 4];
        int count = 0;

        do
        {
            Console.Write("Enter Item Name (or 0 to stop): ");
            string name = Console.ReadLine();

            if (name == "0")
                break;

            Console.Write("Enter Item Price: ");
            string priceInput = Console.ReadLine();

            Console.Write("Enter Item Quantity: ");
            string quantityInput = Console.ReadLine();

            decimal price = Convert.ToDecimal(priceInput);
            int quantity = Convert.ToInt32(quantityInput);
            decimal subtotal = price * quantity;

            items[count, 0] = name;
            items[count, 1] = price.ToString("F2");
            items[count, 2] = quantity.ToString("F0");
            items[count, 3] = subtotal.ToString("F2");

            count++;
        } while (true);

        double total = 0;

        Console.WriteLine("\n--- Receipt ---");
        Console.WriteLine("Item\tPrice\tQuantity\tSubtotal");

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"{items[i, 0]}\t{items[i, 1]}\t{items[i, 2]}\t\t{items[i, 3]}");
            total += Convert.ToDouble(items[i, 3]);
        }

        Console.WriteLine("\n-----------------------");
        Console.WriteLine($"Total Items: {count}");
        Console.WriteLine($"Total Cost: {total:F2}");
    }
}
