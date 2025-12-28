using System;

class Student
{
    private string name;

    public void SetName(string n)
    {
        name = n;
    }

    public string GetName()
    {
        return name;
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student();
        s.SetName("Ali");
        Console.WriteLine(s.GetName());
    }
}
