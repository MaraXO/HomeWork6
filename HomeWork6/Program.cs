using System;

class Program
{
    static void Main()
    {
        // Task1
        //try
        //{
        //    int [] profits = new int [6];
        //    int totalProfit = 0;

        //    for (int i = 0; i < 6; i++)
        //    {
        //        Console.Write($"Enter the profit for the month {i + 1}: ");
        //        profits[i] = Convert.ToInt32(Console.ReadLine());
        //        totalProfit += profits[i];
        //    }

        //    Console.WriteLine($"Total profit for 6 months: {totalProfit}");
        //}
        //catch (FormatException)
        //{
        //    Console.WriteLine("Error: Incorrect number entered.");
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine("Error: " + ex.Message);
        //}


        //Task2

        //try
        //{
        //    int[] profits = new int[12];
        //    for (int i = 0; i < 12; i++)
        //    {
        //        Console.Write($"Enter the profit for the month {i + 1}: ");
        //        profits[i] = Convert.ToInt32(Console.ReadLine());
        //    }

        //    int maxMonth = 0, minMonth = 0;
        //    for (int i = 1; i < 12; i++)
        //    {
        //        if (profits[i] > profits[maxMonth])
        //        {
        //            maxMonth = i;
        //        }
        //        if (profits[i] < profits[minMonth])
        //        {
        //            minMonth = i;
        //        }
        //    }

        //    Console.WriteLine($"Month with maximum profit: {maxMonth + 1}, profit: {profits[maxMonth]}");
        //    Console.WriteLine($"Month with minimum profit: {minMonth + 1}, profit: {profits[minMonth]}");
        //}
        //catch (FormatException)
        //{
        //    Console.WriteLine("Error: Incorrect number entered.");
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine("Error: " + ex.Message);
        //}


        //Task3

        try
        {
            
            Random rand = new Random();
            int[] array = new int[20];

            
            for (int i = 0; i < 20; i++)
            {
                array[i] = rand.Next(0, 10);
            }

            
            Console.WriteLine("Initial array:");
            foreach (int value in array)
            {
                Console.Write($"{value} ");
            }
            Console.WriteLine();

            
            int[] compressedArray = new int[20];
            int index = 0;

            
            for (int i = 0; i < 20; i++)
            {
                if (array[i] != 0)
                {
                    compressedArray[index] = array[i];
                    index++;
                }
            }

            
            for (int i = index; i < 20; i++)
            {
                compressedArray[i] = -1;
            }

            
            Console.WriteLine("Compressed Array:");
            foreach (int value in compressedArray)
            {
                Console.Write($"{value} ");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
