using System;

public class ListingActivity : Activity {
    private int _count;

    private List<string> _prompt;

    public ListingActivity(string name, string desc) : base(name, desc) {

        _prompt = new List<string> {"Who are people that you appreciate?",
                                "What are personal strengths of yours?",
                                "Who are people that you have helped this week?",
                                "When have you felt the Holy Ghost this month?",
                                "Who are some of your personal heroes?"};
        
    }

    public void Run() {
        Console.WriteLine("LisTing your thoughts to The following Prompt: ");
        GetRandomPrompt();
        Console.WriteLine();
        Console.Write("Now we begin in...");
        ShowCountDown(5);
        GetListFromUser();
        Console.WriteLine();
        Console.WriteLine($"You have {_count} responce to the prompt.");
    }

    public void GetRandomPrompt() {
        Random random = new Random();
        int index = random.Next(_prompt.Count);
        Console.WriteLine($"            ---{_prompt[index]}---");
    }

    public List<string> GetListFromUser(){
        List<string> list = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(d());
        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
            {
                Console.Write(">");
                list.Add(Console.ReadLine());
        currentTime = DateTime.Now;
        }
        _count = list.Count;

        return list;


    }
}
