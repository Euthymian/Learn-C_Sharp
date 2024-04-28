// See https://aka.ms/new-console-template for more information
public class Program {
    public static void Main(string[] args) {
        // SnakeGame game = new SnakeGame();
        // game.Run();
        Shape[] shapes = [
            new Circle("red", 2),
            new Rectangle("blue", 3, 4),
            new Square("green", 5)
        ];
        System.Console.WriteLine("Before resizing:");
        foreach (Shape shape in shapes) {
            System.Console.WriteLine(shape.ToString());
        }
        Random rand = new Random();
        System.Console.WriteLine("After resizing:");
        foreach (Shape shape in shapes) {
            int percent = rand.Next(1, 100);
            shape.Resize(percent);
            System.Console.WriteLine($"Resized by {percent}");
            System.Console.WriteLine(shape.ToString());
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