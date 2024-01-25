using System;

class Program
{
    static void Main(string[]args)
    {
        Console.WriteLine("Please enter your grade percentage:")
        string grade_percentage = Console.ReadLine;
        int int_conversion = int.Parse(grade_percentage);

        letter = "";

        if (grade_percentage >= 90)
        {
            letter = "A";
        }
        else if (grade_percentage >= 80)
        {
            letter = "B";    
        }
        else if (grade_percentage >= 70)
        {
            letter = "C";      
        }
        }
        else if (grade_percentage >= 60)
        {
            letter = "D";     
        }
        else (grade_percentage < 60)
        {
            letter = "F";  
        }
     
        if (grade_percentage >= 70)
        {
           Console.WriteLine("Congratulations! You have passed the course.");
        }
        else
        {
           Console.WriteLine("We are so sorry.");
           Console.WriteLine("You should get at least 70% to pass this course.")
           Console.WriteLine("You are always welcome to take this class")
        }



    }

}