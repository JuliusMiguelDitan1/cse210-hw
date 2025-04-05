using System;
/// <summary>
///  The exceeding the requirement task I done is the making sure the prompts on reflecting is not repeating on the session. I suppose the 
/// breathing animation aswell with the the spinner acting as a face for it. 
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Welcome to Your Daily Journal!");
    
        while (true) {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Breathing Activty");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activty");
            Console.WriteLine("4. Quit");

            Console.Write("Please select an option (1-4) ");
            string choice = Console.ReadLine();

            switch (choice) {
                
                case "1":
                Console.Clear();
                BreathingActivity breath = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly.\n Clear your mind and focus on your breathing.");
                breath.DisplayStartingMessage();
                Console.WriteLine();
                Console.Clear();
                Console.WriteLine("Be ready...");
                breath.ShowSpinner(3);
                breath.Run();
                breath.DisplayEndingMessage();
                Console.Clear();
                
                break;

                case "2":
                Console.Clear();
                ReflectingActivity Reflect = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. \n This will help you recognize the power you have and how you can use it in other aspects of your life.");
                Reflect.DisplayStartingMessage();
                Console.WriteLine();
                Console.Clear();
                Console.WriteLine("Be ready...");
                Reflect.ShowSpinner(3);
                Reflect.Run();
                Reflect.DisplayEndingMessage();
                Console.Clear();
                break;

                case "3":
                Console.Clear();
                ListingActivity Listing = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                Listing.DisplayStartingMessage();
                Console.WriteLine();
                Console.Clear();
                Console.WriteLine("Be ready...");
                Listing.ShowSpinner(3);
                Listing.Run();
                Listing.DisplayEndingMessage();
                Console.Clear();
                break;

                case "4":
                Console.WriteLine("Goodbye!");
                return;

                default:
                Console.WriteLine("Invalid selection, please enter a number 1-4.");
                break;
            }
        }
    }
}