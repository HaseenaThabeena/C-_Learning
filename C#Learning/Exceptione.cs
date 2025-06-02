using System;

class Exceptione
{
    public void exe()
    {
        try
        {
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("You entered: " + number);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            Console.ReadKey();
        }
        
        finally
        {
            Console.WriteLine("This block always executes.");
            Console.ReadKey();
        }
    }
}
