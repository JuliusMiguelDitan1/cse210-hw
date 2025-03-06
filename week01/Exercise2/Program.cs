using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade? ");
        string input = Console.ReadLine();
        int grade = int.Parse(input);
        string letter = "";

        if (grade >= 90)
            {
                if (grade > 93)
                {
                letter ="A";
                }
                else 
                {
                    letter ="-A";
                }
            }
        else if (grade >= 80)
            {
                if (grade > 87)
                {
                letter ="+B";
                }
                else if (grade < 87 && grade > 83)
                {
                    letter ="B";
                }
                else 
                {
                    letter ="-B";
                }
            }
        else if (grade >= 70)
            {
                if (grade > 77)
                {
                letter ="+C";
                }
                else if (grade < 77 && grade > 73)
                {
                    letter ="C";
                }
                else 
                {
                    letter ="-C";
                }
            }
        else if (grade >= 60)
            {
               if (grade > 67)
                {
                letter ="+D";
                }
                else if (grade < 67 && grade > 63)
                {
                    letter ="D";
                }
                else 
                {
                    letter ="-D";
                }
            }
         else
            {
                letter ="F";
            }

        Console.WriteLine(letter);
        if (grade >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else 
        {
            Console.WriteLine("You did not pass");
        }
    }
}