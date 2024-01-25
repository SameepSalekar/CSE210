using System

class Program
{

    static void Main(string[]args)
    {
        DisplayWelcomeMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int SquaredNumber = SquareNumber(int favorite_number);

        DisplayResult(userName, SquaredNumber);
    }
   static void DisplayWelcome()
   {
    Console.WriteLine("Welcome to the Program");
   } 

   static void PromptUserName()
   {
    Console.Write("Enter your name: ")
    user_name = Console.ReadLine();
    return user_name
   }

    static int PromptUserNumber()
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

    static void DisplayResult(string user_name, int squared_number)
    {

        Console.WriteLine($"{user_name}, the square of your number is {squared_number}");

    }
}