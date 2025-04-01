using System;

public class Assignment 
{
    private string _studentName;
    private string _topic;

    public Assignment(string Name, string Topic) {
        _studentName = Name;
        _topic = Topic;

    }
    public string GetStudentName()
    {
        return _studentName;
    }

    public string GetTopic()
    {
        return _topic;
    }


    public string Getsummary() {
        string a = $"{_studentName} - {_topic}";
        return a;
    }
}