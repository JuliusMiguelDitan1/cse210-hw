using System;

public class MathAssignment : Assignment{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string Name, string Topic, string section, string prob) : base(Name, Topic) {
        _textbookSection = section;
        _problems = prob;
    }

    public string GetHomeworkList() {
        string a = $"Section {_textbookSection}, problem {_problems}";
        return a;
    }

}