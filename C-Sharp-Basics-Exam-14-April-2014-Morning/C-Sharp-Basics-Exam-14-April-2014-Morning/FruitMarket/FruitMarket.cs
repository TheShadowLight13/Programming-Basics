using System;
using System.Threading;
using System.Globalization;
using System.Linq;

class FruitMarket
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        string dayOfWeek = Console.ReadLine();
        double[] quantity = new double[3];
        string[] products = new string[3];
        double totalPrice = 0;

        for (int i = 0; i < 3; i++)
        {
            quantity[i] = double.Parse(Console.ReadLine());
            products[i] = Console.ReadLine();
        }

        for (int i = 0; i < 3; i++)
        {
            switch (products[i])
            {
                case "banana":
                    totalPrice += 1.80 * quantity[i];
                    break;
                case "cucumber":
                    totalPrice += 2.75 * quantity[i];
                    break;
                case "tomato":
                    totalPrice += 3.20 * quantity[i];
                    break;
                case "orange":
                    totalPrice += 1.60 * quantity[i];
                    break;
                case "apple":
                    totalPrice += 0.86 * quantity[i];
                    break;
            }
        }


        switch (dayOfWeek)
        {
            case "Friday":
                totalPrice = totalPrice - (totalPrice * 0.1);
                break;

            case "Sunday":
                totalPrice = totalPrice - (totalPrice * 0.05);
                break;

            case "Tuesday":

                for (int i = 0; i < 3; i++)
                {
                    if (products[i] == "banana")
                    {
                        totalPrice = totalPrice - (quantity[i] * 1.80 * 0.2);
                    }
                    else if (products[i] == "orange")
                    {
                        totalPrice = totalPrice - (quantity[i] * 1.60 * 0.2);
                    }
                    else if (products[i] == "apple")
                    {
                        totalPrice = totalPrice - (quantity[i] * 0.86 * 0.2);
                    }
                }
                break;

            case "Wednesday":
                for (int i = 0; i < 3; i++)
                {
                    if (products[i] == "cucumber")
                    {
                        totalPrice = totalPrice - (quantity[i] * 2.75 * 0.1);
                    }
                    else if (products[i] == "tomato")
                    {
                        totalPrice = totalPrice - (quantity[i] * 3.2 * 0.1);
                    }
                }
                break;

            case "Thursday":

                if (products.Contains("banana"))
                {
                    int index = Array.IndexOf(products, "banana");
                    totalPrice = totalPrice - (quantity[index] * 1.8 * 0.3);
                }

                break;
        }

        Console.WriteLine("{0:F2}", totalPrice);

    }
}

