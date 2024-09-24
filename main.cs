using System;

class HomeSales
{
    static void Main()
    {
        double salesD = 0.0, salesE = 0.0, salesF = 0.0, grandTotal = 0.0;
        char initial;

        do
        {
            Console.Write("Enter salesperson's initial (D, E, F) or Z to quit: ");
            initial = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            if (initial == 'Z')
                break;

            if (initial == 'D' || initial == 'E' || initial == 'F')
            {
                Console.Write("Enter the sale amount: ");
                double saleAmount = double.Parse(Console.ReadLine());

                if (initial == 'D')
                    salesD += saleAmount;
                else if (initial == 'E')
                    salesE += saleAmount;
                else if (initial == 'F')
                    salesF += saleAmount;

                grandTotal += saleAmount;
            }
            else
            {
                Console.WriteLine("Error, invalid salesperson selected, please try again.");
            }

        } while (true);

        Console.WriteLine("\nSales Summary:");
        Console.WriteLine($"Danielle's total sales: ${salesD:F2}");
        Console.WriteLine($"Edward's total sales: ${salesE:F2}");
        Console.WriteLine($"Francis' total sales: ${salesF:F2}");
        Console.WriteLine($"Grand total sales: ${grandTotal:F2}");

        string topSalesPerson;
        double highestSales = Math.Max(salesD, Math.Max(salesE, salesF));

        if (highestSales == salesD)
            topSalesPerson = "Danielle";
        else if (highestSales == salesE)
            topSalesPerson = "Edward";
        else
            topSalesPerson = "Francis";

        Console.WriteLine($"Highest Sale: {topSalesPerson}");
    }
}