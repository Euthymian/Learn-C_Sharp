// See https://aka.ms/new-console-template for more information
public class Program {
    public static void Main(string[] args) {
        // SnakeGame game = new SnakeGame();
        // game.Run();

        ComparableCircle[] circles = new ComparableCircle[3];
        circles[0] = new ComparableCircle(3.6);
        circles[1] = new ComparableCircle();
        circles[2] = new ComparableCircle(3.5, "indigo");

        System.Console.WriteLine("Pre-sorted:");
        foreach (ComparableCircle circle in circles) {
            System.Console.WriteLine(circle.ToString());
        }
        Array.Sort(circles);
        System.Console.WriteLine("After-sorted:");
        foreach (ComparableCircle circle in circles) {
            System.Console.WriteLine(circle.ToString());
        }
    }
}



// Animal cat = new Cat("20kg", "1.5", "kitty");
// cat.PrintInfo();
// System.Console.WriteLine();
// System.Console.WriteLine(cat.GetType());
// System.Console.WriteLine();
// cat = new Kitten("10kg", "1", "kitty", 2);
// cat.PrintInfo();


// Practice.MeasureSortTime();

// Human h1 = new SpecialPerson("John", 20, "Male", "Eye-Laser");
// h1.PrintInfo();


// Vehicle v1 = new Car("Car");
// v1.Drive();

// System.Console.WriteLine("\n\n");
// DerivedC b = new DerivedC();
// b.Invoke();
// System.Console.WriteLine(b.Print);

// System.Console.WriteLine();
// BaseC baseC = new DerivedC();
// baseC.Invoke();

// System.Console.WriteLine("\n\n");
// Circle c = new Cylinder(1, "red", 2);
// System.Console.WriteLine(c.ToString());

// Animal1[] animals = [new Tiger(), new Chicken()];

// foreach (Animal1 animal in animals)
// {
//     Console.WriteLine(animal.MakeSound());
//     if (animal is Chicken)
//     {
//     IEdible edibler = (Chicken)animal;
//     edibler.HowToEat();
//     }
// }