using System;

class Circle : Shape
{
    //attributes
    private string _shape = "circle";
    private double _radius;

    //Constructors
    public Circle(double radius, string color) : base (color)
    {
        SetRadius(radius);
    }

    //methods
    private void SetRadius(double radius)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        double area = 3.14 * (_radius * _radius);

        return area;
    }

    public override string GetShape()
    {
        return _shape;
    }
}