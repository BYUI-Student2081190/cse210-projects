using System;

public class Fraction
{
    //Attributes
    private int _topNum;
    private int _bottomNum;

    //Constructor
    public Fraction()
    {
        _topNum = 1;
        _bottomNum = 1;
    }

    public Fraction(int top)
    {
        _topNum = top;
        _bottomNum = 1;
    }

    public Fraction(int top, int bottom)
    {
        _topNum = top;
        _bottomNum = bottom;
    }

    //Getters and Setters
    public string getFractionString()
    {
        return ($"{_topNum}/{_bottomNum}");
    }

    public double getDecimalValue()
    {
        double _doubleTopNum = _topNum;
        double _doubleBottomNum = _bottomNum;

        double decimalValue = (_doubleTopNum/_doubleBottomNum);

        return (decimalValue);
    }
}