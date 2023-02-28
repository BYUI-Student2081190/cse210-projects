using System;

class Square : Shape
{

    //attributes
    private double _side;
    private string _shape = "square";

    //constuctor
    public Square(double side, string color) : base (color)
    {
        SetSide(side);
    }

    //methods
    private void SetSide(double side)
    {
        _side = side;
    }

    public override string GetShape()
    {
        return _shape;
    }

    public override double GetArea()
    {
        double area = _side * _side;

        return area;
    }
}