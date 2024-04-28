class Human {
    public string Name { get; set; }
    public int Age { get; set; }
    public Human(string name, int age) {
        this.Name = name;
        this.Age = age;
    }
    public virtual void PrintInfo() {
        System.Console.WriteLine("Name: {0}" + '\n' + "Age: {1}", this.Name, this.Age);
    }
}

class NormalPerson : Human {
    public string Gender { get; set; }
    public NormalPerson(string name, int age, string gender) : base(name, age) {
        this.Gender = gender;
    }
    public override void PrintInfo() {
        base.PrintInfo();
        System.Console.WriteLine("Gender: {0}", this.Gender);
    }
}

class SpecialPerson : NormalPerson {
    public string Speciality { get; set; }
    public SpecialPerson(string name, int age, string gender, string speciality) : base(name, age, gender) {
        this.Speciality = speciality;
    }
    public override void PrintInfo() {
        base.PrintInfo();
        System.Console.WriteLine("Speciality: {0}", this.Speciality);
    }
}

abstract class Vehicle {
    public string Model { get; set; }
    public Vehicle(string model) {
        this.Model = model;
    }
    public virtual void PrintInfo() {
        System.Console.WriteLine("Model: {0}", this.Model);
    }

    public abstract void Drive();
}

class Carr : Vehicle {
    public Carr(string model) : base(model) {}
    public override void Drive() {
        System.Console.WriteLine("Driving a car");
    }
}

public class BaseC
{
    public int x;
    public void Invoke() { 
        System.Console.WriteLine("BaseC.Invoke");
    }
    public int Print() {
        System.Console.WriteLine("BaseC.Print");
        return 0;
    }
    public virtual void Show() {
        System.Console.WriteLine("BaseC.Show");
    }
}

public class DerivedC : BaseC
{
    public new void Invoke() {
        System.Console.WriteLine("DerivedC.Invoke");
    }
    public DerivedC() {
        Print = 1;
    }
    public new int Print;
    // Without "new" keyword, there will be a warning of 
    // an existing member with the same name at the base class


    public void InvokeBase() {
        base.Invoke();
    }

    public sealed override void Show() {
        System.Console.WriteLine("DerivedC.Show");
    }

    // The "sealed" keyword prevents the method from being overridden
}

public class DerivedD : DerivedC
{
    // public override void Show() {
    //     System.Console.WriteLine("DerivedD.Show");
    // }

    // ---> This will cause an error because the method is sealed in the base class
}

abstract class A {
    public abstract void Print();
}