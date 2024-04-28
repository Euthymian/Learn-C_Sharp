using System.Diagnostics.CodeAnalysis;
struct Point2D : IComparable<Point2D>
{
    public int x;
    public int y;
    public Point2D(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    public override bool Equals([NotNullWhen(true)] object? obj)
    {
        return base.Equals(obj);
    }
    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
    public static bool operator ==(Point2D a, Point2D b)
    {
        return a.x == b.x && a.y == b.y;
    }
    public static bool operator !=(Point2D a, Point2D b)
    {
        return a.x!=b.y || a.y!=b.x;
    }

    public int CompareTo(Point2D other)
    {
        // This is ascending order
        if (x > other.x) return 1;
        else if (x < other.x) return -1;
        else return 0;

        // This is descending order
        // if (other.x > x) return 1;
        // else if (other.x < x) return -1;
        // else return 0;

        /*
        If take the actual Point2D compare with the other Point2D
        return 1 means the actual Point2D should be after the other Point2D
        return -1 means the actual Point2D should be before the other Point2D
        return 0 means keep the order
        */
    }
}

/* Try this at main:
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
*/