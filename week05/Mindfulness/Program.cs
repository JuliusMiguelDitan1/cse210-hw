using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breath = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly.\n Clear your mind and focus on your breathing.");
        breath.DisplayStartingMessage();
        Console.WriteLine();
        Console.Clear();
        Console.WriteLine("Be ready...");
        breath.ShowSpinner(3);
        breath.Run();
        breath.DisplayEndingMessage();


        //var rand = new Random();
        //List<int> listNumbers = new List<int>();
        //int number;
        //    for (int i = 0; i < 6; i++)
        //        {
        //            do {
        //                    number = rand.Next(1, 7);
        //        } while (listNumbers.Contains(number)); {
        //            listNumbers.Add(number);
        //        }
        //        Console.WriteLine(listNumbers[i]);
        //        }
    }
}