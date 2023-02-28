using System;

//Shape Base Class
class Shape
{
    //attributes
    private string _color;

    //constructor
    public Shape(string color)
    {
        SetColor(color);
    }

    //methods

    private void SetColor(string color)
    {
        _color = color;
    }

    public string GetColor()
    {
        return _color;
    }

    //virtual method for GetArea
    public virtual double GetArea()
    {
        return -1.2;
    }

    //Vitual method to GetShape as well
    public virtual string GetShape()
    {
        return "unknown shape";
    }
}