using System;

public class Activity {
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string desc) {
        _name = name;
        _description = desc;
        
    }

    public int d() {
        return _duration;
    }

    public void DisplayStartingMessage() {
        Console.WriteLine($"Welcome to {_name}");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds do to you want the session to last?: ");
        _duration = int.Parse(Console.ReadLine());

    }

    public void DisplayEndingMessage() {
        Console.WriteLine("Well Done!");
        ShowSpinner(3);
        Console.WriteLine($"You have Completed another {_name}.");
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds) {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);

        DateTime currentTime = DateTime.Now;
        
        while (currentTime < futureTime)
            {
        Console.Write("<[*_*]>");
        Thread.Sleep(500);
        Console.Write("\b\b\b\b\b\b\b"); 
        Console.Write("<[o_o]>"); 
        Thread.Sleep(500);
        Console.Write("\b\b\b\b\b\b\b"); 
        currentTime = DateTime.Now;
            }

    }

    public void ShowCountDown(int seconds) {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);

        DateTime currentTime = DateTime.Now;
        int i = 0; 
        while (currentTime < futureTime)
            {
                i++;
                Console.Write("\b \b"); // Erase the + character
                Console.Write(i);
                Thread.Sleep(1000);
        currentTime = DateTime.Now;
        }


    }
}