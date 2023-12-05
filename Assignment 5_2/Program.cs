using System;

class Program
{
    static void Main()
    {
        try
        {
            
            int[] numbers = { 1, 2, 3, 4, 5 };

           
            int value = numbers[10];

            
            Console.WriteLine("Value at index 10: " + value);
        }
        catch (IndexOutOfRangeException ex)
        {
            
            Console.WriteLine("Error: " + ex.Message);
        }

        Console.ReadLine(); 
    }
}
