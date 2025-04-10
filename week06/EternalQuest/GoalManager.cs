using System;

public class GoalManager {
    public List<Goal> _goal;
    public int _points;

    public GoalManager() {
        _goal = new List<Goal>();
        _points = 0;
    }

    public void Start() {
        while (true) {
            Console.WriteLine($"You have {_points} points.");
            Console.WriteLine();

            Console.WriteLine("Menu:");
            Console.WriteLine("1. Create New Goals");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Load Goals");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Record  Event");
            Console.WriteLine("6. Quit");

            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            switch (choice) {
                
                case "1":
                
                Console.WriteLine("Menu:");
                Console.WriteLine();
                Console.WriteLine("1. Create New Goals");
                Console.WriteLine("2. List Goals");
                Console.WriteLine("3. Load Goals");
                Console.WriteLine();
                Console.Write("Select a choice from the menu: ");
                string go = Console.ReadLine();

                switch (go) {
                    case "1":
                        Console.Write("Name your goal: ");
                        string a = Console.ReadLine();

                        Console.Write("Describe it breifly: ");
                        string b = Console.ReadLine();

                        Console.Write("How much points does it give you?: ");
                        int c = int.Parse(Console.ReadLine());

                        _goal.Add(new EternalGoal(a,b,c));
                    break;

                    case "2":
                    Console.Write("*_*");
                    break;

                    case "3":
                    Console.Write("*_*");
                    break;

                    default:
                    Console.WriteLine("Invalid Choice, please enter a number 1-3.");
                    break;
                    }
                break;

                case "2":
                
                break;

                case "3":
                
                break;

                case "4":
                
                break;

                case "5":

                break;

                case "6":
                Console.WriteLine("Goodbye!");
                return;

                default:
                Console.WriteLine("Invalid selection, please enter a number 1-5.");
                break;
            }
        }

    }
}