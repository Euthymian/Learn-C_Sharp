// See https://aka.ms/new-console-template for more information
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        // SnakeGame game = new SnakeGame();
        // game.Run();


        // Animal cat = new Cat("20kg", "1.5", "kitty");
        // cat.PrintInfo();
        // System.Console.WriteLine();
        // System.Console.WriteLine(cat.GetType());
        // System.Console.WriteLine();
        // cat = new Kitten("10kg", "1", "kitty", 2);
        // cat.PrintInfo();


        // Practice.MeasureSortTime();

        Human h1 = new SpecialPerson("John", 20, "Male", "Eye-Laser");
        h1.PrintInfo();


        Vehicle v1 = new Car("Car");
        v1.Drive();

        System.Console.WriteLine("\n\n");
        DerivedC b = new DerivedC();
        b.Invoke();
        System.Console.WriteLine(b.Print);

        System.Console.WriteLine();
        BaseC baseC = new DerivedC();
        baseC.Invoke();
    }
}