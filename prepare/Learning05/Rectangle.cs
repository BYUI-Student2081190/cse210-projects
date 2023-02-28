using System;

class Rectangle : Shape
{
    //attributes
    private double _width;
    private double _height;

    private string _shape = "rectangle";

    //constructors
    public Rectangle(double width, double height, string color) : base (color)
    {
        //Call setters
        SetWidth(width);
        SetHeight(height);
    }

    //methods

    private void SetWidth(double width)
    {
        _width = width;
    }

    private void SetHeight(double height)
    {
        _height = height;
    }

    //Get area and Get shape
    public override double GetArea()
    {
        double area = _height * _width;

        return area;
    }

    public override string GetShape()
    {
        return _shape;
    }
}