// Shape.cs
public class Shape
{
    // Member variable for color
    private string _color;

    // Constructor to set the color
    public Shape(string color)
    {
        _color = color;
    }

    // Getter for color
    public string GetColor()
    {
        return _color;
    }

    // Setter for color
    public void SetColor(string color)
    {
        _color = color;
    }

    // Virtual method to calculate area (to be overridden by derived classes)
    public virtual double GetArea()
    {
        return 0; // Default implementation returns 0
    }
}