using System;

class Program
{
    static void Main(string[] args)
    {
        string response = "yes";
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do
        {
            Console.Write("Enter number: ");
            int g = int.Parse(Console.ReadLine());
            if (g == 0)
            {
                break;

            }else
            {
                numbers.Add(g);
            }

        }while (response == "yes");
        int sum = 0;
        foreach (int number in numbers)
        {
            sum+=number;
        }
        Console.WriteLine($"The sum is: {sum}");
        float avg = ((float)sum)/numbers.Count;
        Console.WriteLine($"The average is: {avg}");
        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The largest number is: {max}");
        int min = numbers[0];
        foreach (int number in numbers)
        {
            if (number < min)
            {
                min = number;
            }
        }
        Console.WriteLine($"The smallest number is: {min}");
        numbers.Sort();
        Console.WriteLine("The sorted list is: ");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}