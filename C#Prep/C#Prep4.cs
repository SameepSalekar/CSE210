using System
using System.Collections.Generic

class Program
{
    static void Main(String[]args)
    {

        // Printing the first instruction 
        Console.WriteLine("Enter a series of numbers, type 0 when finished.")

        // Creating the list
        List<int> numbers = new List<int>();

        // do-while loop
        int Number = -1
        while (Number != 0)
        {
            Console.Write("Enter the number: ");
            string userInput = Console.ReadLine();
            Number = int.Parse(userInput);


            // if loop
            if(Number != 0) 
            {
                numbers.Add(Number);
            }

        }

        //To comput the total sum
        int sum = 0
        foreach(int numerical in numbers)
        {
            sum += numerical;
        }
        Console.WriteLine($"The sum is: {sum}");

        //To compute the average
        float average = ((float)sum)/numbers.Count;
        Console.WriteLine($"The average is: {average}");

        //To find the maximum number
        int max = numbers[0]
        foreach(int numerical in numbers)
        {
            if (numberical > max)
            {
                max = numerical
            }
        }

        Console.WriteLine($"The max is: {max}");



    }
}