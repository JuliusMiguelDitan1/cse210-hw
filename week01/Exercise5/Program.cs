using System;

class Program
{
    static void Main(string[] args)
    {
     DisplayWelcome();
     string name = PromptUserName();
     int number = PromptUserNumber();
     int square = SquareNumber(number);

    DisplayResult(name, square);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string g = Console.ReadLine();

        return g;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int g = int.Parse(Console.ReadLine());
        return g;
    }
    static int SquareNumber(int number)
    {
        int sq = number * number;
        return sq;
    }
    static void DisplayResult(string name, int number)
    {
        Console.WriteLine($"{name}, the square of your number is {number}");
    }
}