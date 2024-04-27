class Circle {
    protected double radius;
    private string color;

    public double Radius {
        get { return radius; }
        set { radius = value; }
    }

    public string Color {
        get { return color; }
        set { color = value; }
    }

    public Circle(double radius, string color) {
        this.color = color;
        this.radius = radius;
    }
    public virtual double Area() {
        return Math.PI * radius * radius;
    }
    public virtual double Circumference() {
        return 2 * Math.PI * radius;
    }
    public override string ToString() {
        return $"raduis: {radius}, color: {color}, area: {Area()}, circumference: {Circumference()}";
    }
}

class Cylinder : Circle {
    private double height;

    public double Height {
        get { return height; }
        set { height = value; }
    }

    public Cylinder(double radius, string color, double height) : base(radius, color) {
        this.height = height;
    }
    public override double Area() {
        return 2 * Math.PI * radius * (Radius + height);
    }
    public double Volume() {
        return Math.PI * Radius * Radius * height;
    }
    public override string ToString() {
        return $"raduis: {Radius}, color: {Color}, area: {Area()}, volume: {Volume()}";
    }
}