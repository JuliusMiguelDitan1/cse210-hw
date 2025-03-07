using System;

class Program
{
    static void Main(string[] args)
    {
        string response = "yes";
        while (response == "yes")
        {
            
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 100);
            int i = 0;

            do
            {
               i++;
                Console.Write("What is the magic number? ");
                Console.Write(number);
                string guest = Console.ReadLine();
                int g = int.Parse(guest);
                if (g == number)
                {
                    Console.WriteLine("You guessed it!");
                    break;
                }
                else  if (g < number)
                {
                    Console.WriteLine("higher");

                }else  if (g > number)
                {
                    Console.WriteLine("lower");

                } else 
                {
                    Console.WriteLine("Something is wrong");
                }

            }while (response == "yes");
                Console.WriteLine(i); 
            Console.Write("Do you want to try again? ");
            response = Console.ReadLine();
        }
    }
}