using System;

class Program
{
    static void Main(string[] args)
    {
        Running running = new Running(30,"02 Apr 2022", 12);
        running.GetSummary();
        Cycling cycling = new Cycling(30,"03 Apr 2022", 12);
        cycling.GetSummary();
        Swimming swim = new Swimming(30,"04 Apr 2022", 12);
        swim.GetSummary();
    }
}