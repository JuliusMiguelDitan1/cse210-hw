using System;

public class ReflectingActivity : Activity {

    private List<string> _question;

    private List<string> _prompt;

    public ReflectingActivity(string name, string desc) : base(name, desc)  {
        _question = new List<string> {
                "Why was this experience meaningful to you?...",
                "Have you ever done anything like this before?...",
                "How did you get started?...",
                "How did you feel when it was complete?...",
                "What made this time different than other times when you were not as successful?...",
                "What is your favorite thing about this experience?...",
                "What could you learn from this experience that applies to other situations?...",
                "What did you learn about yourself through this experience?...",
                "How can you keep this experience in mind in the future?..."};
        _prompt = new List<string>  {
                "Think of a time when you stood up for someone else.",
                "Think of a time when you did something really difficult.",
                "Think of a time when you helped someone in need.",
                "Think of a time when you did something truly selfless."};

    }

    public void Run() {
        DisplayPrompt();
        Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Now, ponder on each following questions as they relate to your exprience.");
        Console.Write("Now we begin in...");
        ShowCountDown(5);
        Console.Clear();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(d());
        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
            {
                DisplayQuestion();
                ShowCountDown(5);
        currentTime = DateTime.Now;
        }
        Console.WriteLine();
    }
    public string GetRandomQuestion() {
        var rand = new Random();
        List<int> listNumbers = new List<int>();
        int number;
        int i = 0;
                    do {
                            number = rand.Next(0, _question.Count);
                } while (listNumbers.Contains(number)); {
                    listNumbers.Add(number);
                }
                string a = _question[listNumbers[i]];
                i++;
                return a;
    }

    public string GetRandomPrompt() {
        Random random = new Random();
        int index = random.Next(_prompt.Count);
        return _prompt[index];
    }

    public void DisplayPrompt() {
        Console.WriteLine("Consider The following Prompt: ");
        Console.WriteLine($"            ---{GetRandomPrompt()}---");
        Console.WriteLine();
        Console.WriteLine("When you have somthing in your mind press enter. ");

    }

    public void DisplayQuestion() {
        Console.Write(GetRandomQuestion());
    }

}