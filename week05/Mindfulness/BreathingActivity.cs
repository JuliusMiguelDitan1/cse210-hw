using System;

public class BreathingActivity : Activity {
    public BreathingActivity(string name, string desc) :base (name, desc)  
    {

    }

    public void Run() {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(d());
        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
            {
        Console.WriteLine("Breathe in...");
        ShowSpinner(4);
        Console.WriteLine("Breathe out...");
        ShowSpinner(4);
        currentTime = DateTime.Now;
        }
        
    }

}