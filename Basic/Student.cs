class Student
{
    private string? name;
    private int age;
    private string? major;
    private string? id;

    public string? Name {
        get { return name; }
    }
    public int Age {
        get { return age; }
    }
    public string? Major {
        set { major = value; }
        get { return major; }
    }
    private string? Id {
        get { return id; }
    }
    public Student(string name, int age, string major, string id)
    {
        this.name = name;
        this.age = age;
        this.major = major;
        this.id = id;
    }
    public void Print()
    {
        Console.WriteLine(Name);
        Console.WriteLine(Age);
        Console.WriteLine(Major);
        Console.WriteLine(Id);
    }
}