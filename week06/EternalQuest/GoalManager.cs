using System;

public class GoalManager {
    public List<Goal> _goal;
    public int _points;

    private string a;
    private string b;
    private int c;

    private int Challenge = 100;

    public GoalManager() {
        _goal = new List<Goal>();
        _points = 0;
    }

    public void Start() {
        while (true) {
            DisplayScore();
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
                CreateGoal();
                break;

                case "2":
                ListGoalNames();
                break;

                case "3":
                LoadGoal();
                break;

                case "4":
                SaveGoal();
                break;

                case "5":
                RecordEvent();
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

    public void DisplayScore() {
         Console.WriteLine($"You have {_points}/{Challenge} points.");
        Console.WriteLine();
        ListGoalDetails();
        Console.WriteLine();
    }

    public void ListGoalNames() {
        Console.WriteLine("List of Goals you have created");
        Console.WriteLine();
        int i = 0;
        foreach (Goal Goal in _goal){
            i++;
        Console.WriteLine($"{i}. {Goal.GetDetailsString()}");
        }
        Console.WriteLine();

    }

    public void ListGoalDetails() {
        if (_points < 100 && _points >10){
            Console.WriteLine("Your rank is Wordkeeper");
            Challenge = 200;
        } else if (_points >= 100 && _points < 200){
            Console.WriteLine("Your rank is Achiever");
             Challenge = 300;
        }else if (_points >= 200 && _points < 300 ){
            Console.WriteLine("Your rank is Hunter");
            Challenge = 400;
        }
        else if (_points >= 300 && _points < 400){
            Console.WriteLine("Your rank is Head Hunter");
            Challenge = 500;
        }
        else if (_points >= 400 && _points < 500){
            Console.WriteLine("Your rank is Savant");
            Challenge = 600;
        }
        else if (_points >= 500 && _points < 700){
            Console.WriteLine("Your rank is Laurel");
            Challenge = 700;
        }
        else {
            Console.WriteLine("Your rank is Humble Dreamer");
        }

    }

    public void CreateGoal(){
        while (true) {
        Console.WriteLine("These are the goal type to  choose from:");
                Console.WriteLine();
                Console.WriteLine("1. Eternal Goals");
                Console.WriteLine("2. Simple Goals");
                Console.WriteLine("3. Checklist Goals");
                Console.WriteLine();
                Console.Write("Select a goal from the menu: ");
                string go = Console.ReadLine();

                switch (go) {
                    case "1":
                        Console.Write("Name your goal: ");
                        a = Console.ReadLine();

                        Console.Write("Describe it briefly: ");
                        b = Console.ReadLine();

                        Console.Write("How much points does it give you?: ");
                        c = int.Parse(Console.ReadLine());
                        
                        _goal.Add(new EternalGoal(a,b,c));
                    return;

                    case "2":
                    Console.Write("Name your goal: ");
                        a = Console.ReadLine();

                        Console.Write("Describe it briefly: ");
                        b = Console.ReadLine();

                        Console.Write("How much points does it give you?: ");
                        c = int.Parse(Console.ReadLine());
                        
                        _goal.Add(new SimpleGoal(a,b,c,false));
                    return;

                    case "3":
                    Console.Write("Name your goal: ");
                        a = Console.ReadLine();

                        Console.Write("Describe it briefly: ");
                        b = Console.ReadLine();

                        Console.Write("How much points does it give you?: ");
                        c = int.Parse(Console.ReadLine());

                    Console.Write("How many times?: ");
                        int d = int.Parse(Console.ReadLine());

                    Console.Write("How much bonus points?: ");
                        int e = int.Parse(Console.ReadLine());
                        
                        _goal.Add(new ChecklistGoal(a,b,c,false,d,e));
                    return;

                    default:
                    Console.WriteLine("Invalid Choice, please enter a number 1-3.");
                    break;
                    }
        }

    }

    public void RecordEvent() {
        ListGoalNames();
        Console.WriteLine("Which Goal did you complete? ");
        int go = int.Parse(Console.ReadLine())-1;
            _points = _points + _goal[go].Score();
            _goal[go].RecordEvent();
            _points = _points+ + _goal[go].Bonus();
            
    }

    public void SaveGoal() {
        Console.Write("Filename: ");
        string filename = Console.ReadLine();
        using (StreamWriter writer = new StreamWriter(filename)) {
            writer.WriteLine(_points);
                foreach (Goal Goal in _goal) {
                    writer.WriteLine($"{Goal.GetStringRepresentation()}");
                }
            }
            Console.WriteLine($"Goals saved to {filename}");

    }

    public void LoadGoal() {
        Console.Write("Filename: ");
        string filename = Console.ReadLine();
        try {
            string[] lines = System.IO.File.ReadAllLines(filename);
            _points = int.Parse(lines[0]);

            for (int i =1; i < lines.Length; i++ )
            {
                string[] parts = lines[i].Split(":");
                switch(parts[0]) {
                        case "EternalGoal":
                            _goal.Add(new EternalGoal(parts[1],parts[2],int.Parse(parts[3])));
                        break;

                        case "SimpleGoal":
                            _goal.Add(new SimpleGoal(parts[1],parts[2],int.Parse(parts[3]),bool.Parse(parts[4])));
                        break;

                        case "ChecklistGoal":
                            _goal.Add(new ChecklistGoal(parts[1],parts[2],int.Parse(parts[3]),bool.Parse(parts[4]),int.Parse(parts[5]),int.Parse(parts[6])));
                        break;
                }
            }
            } catch (Exception e) {
                Console.WriteLine($"Error loading goals from :filename: {e.Message}");
        }

    }
}