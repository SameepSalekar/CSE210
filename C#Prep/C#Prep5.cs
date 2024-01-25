using System

class Program
{
   static void DisplayWelcome()
   {
    Console.WriteLine("Welcome to the Program");
   } 

   static void PromptUserName(string user_name)
   {
    Console.Write("Enter your name: ")
    user_name = Console.ReadLine();
    return user_name
   }

    static int PromptUserNumber(int favorite_number)
    {
        Console.Write("Enter your favorite number: ")
        favorite_number = Conosle.ReadLine();
        int_conversion = int.Parse(favorite_number);
        return favorite_number;
    }

    static int SquareNumber(int favorite_number)
    {
        squared_number = favorite_number * favorite_number
        return squared_number; 
    }

    static void DisplayResult(string[]args)
    {
        Console.WriteLine(DisplayWelcome);
        Console.WriteLine(PromptUserName);
        Console.WriteLine(PromptUserNumber);
        Console.WriteLine(SquareNumber);
        Console.WriteLine($"{user_name}, the square of your number is {squared_number}");

    }
}