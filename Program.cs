// See https://aka.ms/new-console-template for more information
public class Program {
    public static void Main(string[] args) {
        // SnakeGame game = new SnakeGame();
        // game.Run();

        Point2D[] arr = [
        new Point2D(1, 2),
        new Point2D(10, 4),
        new Point2D(3, 6),
        new Point2D(5, 8),
        new Point2D(9, 10)
    ];

    System.Console.WriteLine("Before sorting:");
    foreach (Point2D p in arr) {
        System.Console.WriteLine("Point: " + p.x + " " + p.y);
    }
    Array.Sort(arr);
    System.Console.WriteLine("\nAfter sorting:");
    foreach (Point2D p in arr) {
        System.Console.WriteLine("Point: " + p.x + " " + p.y);
    }
    
    // Car[] arrayOfCars =
    // [
    //     new Car("Ford",1992),
    //     new Car("Fiat",1988),
    //     new Car("Buick",1932),
    //     new Car("Ford",1932),
    //     new Car("Dodge",1999),
    //     new Car("Honda",1977)
    // ];

    // // Write out a header for the output.
    // Console.WriteLine("Array - Unsorted\n");

    // foreach(Car c in arrayOfCars)
    //     Console.WriteLine(c.Make + "\t\t" + c.Year);

    // // Demo IComparable by sorting array with "default" sort order.
    // Array.Sort(arrayOfCars);
    // Console.WriteLine("\n---------------------\nArray - Sorted by Make (Ascending - IComparable)\n");

    // foreach(Car c in arrayOfCars)
    //     Console.WriteLine(c.Make + "\t\t" + c.Year);

    // // Demo ascending sort of numeric value with IComparer.
    // Array.Sort(arrayOfCars,Car.SortYearAscending());
    // Console.WriteLine("\n---------------------\nArray - Sorted by Year (Ascending - IComparer)\n");

    // foreach(Car c in arrayOfCars)
    //     Console.WriteLine(c.Make + "\t\t" + c.Year);

    // // Demo descending sort of string value with IComparer.
    // Array.Sort(arrayOfCars,Car.SortMakeDescending());
    // Console.WriteLine("\n---------------------\nArray - Sorted by Make (Descending - IComparer)\n");

    // foreach(Car c in arrayOfCars)
    //     Console.WriteLine(c.Make + "\t\t" + c.Year);

    // // Demo descending sort of numeric value using IComparer.
    // Array.Sort(arrayOfCars,Car.SortYearDescending());
    // Console.WriteLine("\n---------------------\nArray - Sorted by Year (Descending - IComparer)\n");

    // foreach(Car c in arrayOfCars)
    //     Console.WriteLine(c.Make + "\t\t" + c.Year);
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