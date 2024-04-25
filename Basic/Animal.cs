public abstract class Animal
 {
    protected string Weight { get; set; }
    protected string Height { get; set; }

    public Animal(string weight, string height)
    {
        this.Weight = weight;
        this.Height = height;
    }
    public abstract void PrintInfo();
}

class Cat : Animal
{
    protected string Name { get; set; }
    public Cat(string weight, string height, string name) : base(weight, height)
    {
        this.Name = name;
    }

    public override void PrintInfo()
    {
        System.Console.WriteLine("Cat: ");
        Console.WriteLine("Weight : {0}" + '\n' + "Height: {1}" + '\n' + "Name: {2}", this.Weight, this.Height, this.Name);
    }
}

class Kitten : Cat
{
    private int age;
    public Kitten(string weight, string height, string name, int age)
    : base(weight, height, name)
    {
        this.age = age;
    }
    public override void PrintInfo()
    {
        System.Console.WriteLine("Kitten: ");
        Console.WriteLine("Weight : {0}" + '\n' + "Height: {1}" + '\n' + "Name: {2}" + '\n' + "Age: {3}", this.Weight, this.Height, this.Name, this.age);
    }
}