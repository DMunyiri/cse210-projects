// Rectangle.cs
public class Rectangle : Shape
{
    // Private member variables for width and height
    private double _width;
    private double _height;

    // Constructor to initialize color, width, and height
    public Rectangle(string color, double width, double height) : base(color)
    {
        _width = width;
        _height = height;
    }

    // Override the GetArea method
    public override double GetArea()
    {
        return _width * _height;
    }
}