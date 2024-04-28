interface IResizeable {
    void Resize(double percent);
}

abstract class Shape : IResizeable {
    protected string? color;
    public Shape(string color) {
        this.color = color;
    }
    public abstract double Area();
    public abstract void Resize(double percent);
}

class Circle : Shape {
    private double radius;
    public Circle(string color, double radius) : base(color) {
        this.radius = radius;
    }
    public override double Area() {
        return Math.PI * radius * radius;
    }
    public override void Resize(double percent) {
        radius *= percent / 100;
    }
    public override string ToString()
    {
        return $"CIRCLE with: \nradius: {radius}, color: {color}, area: {Area()}\n";
    }
}

class Rectangle : Shape {
    private double width;
    private double length;
    public Rectangle(string color, double width, double length) : base(color) {
        this.width = width;
        this.length = length;
    }
    public override double Area() {
        return width * length;
    }
    public override void Resize(double percent) {
        width *= percent / 100;
        length *= percent / 100;
    }
    public override string ToString()
    {
        return $"RECTANGLE with: \nwidth: {width}, length: {length}, color: {color}, area: {Area()}\n";
    }
}

class Square : Shape {
    private double side;
    public Square(string color, double side) : base(color) {
        this.side = side;
    }
    public override double Area() {
        return side * side;
    }
    public override void Resize(double percent) {
        side *= percent / 100;
    }
    public override string ToString()
    {
        return $"SQUARE with: \nside: {side}, color: {color}, area: {Area()}\n";
    }
}

/*
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
*/