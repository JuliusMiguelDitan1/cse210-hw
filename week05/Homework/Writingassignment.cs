using System;

public class WritingAssignment : Assignment
{
    private string _title;
public WritingAssignment(string Name, string Topic, string Title) :base(Name, Topic) {
    _title = Title;
}

public string GetWritingInformation() {
    string a = $"{_title}";
    return a;
}
}