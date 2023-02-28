using System;

class Program
{
    static void Main(string[] args)
    {
        //instances
        Square square1 = new Square(5.60, "blue");
        Circle circle1 = new Circle(2.5, "red");
        Rectangle rec1 = new Rectangle(1.2, 3.5, "yellow");
        Square square2 = new Square(2.3, "pink");
        Rectangle rec2 = new Rectangle(4, 2.3, "black");
        Circle circle2 = new Circle(3.5, "aqua");

        //Put them into a list
        List<Shape> shapeList = new List<Shape>();

        shapeList.Add(square1);
        shapeList.Add(circle1);
        shapeList.Add(rec1);
        shapeList.Add(square2);
        shapeList.Add(rec2);
        shapeList.Add(circle2);

        //Call display for each shape
        //Call display function
        foreach (Shape shape in shapeList)
        {
            DisplayShape(shape);
        }

        //Display
        void DisplayShape(Shape currShape)
        {
            double area = currShape.GetArea();

            string shape = currShape.GetShape();

            string color = currShape.GetColor();

            //Display it

            Console.WriteLine($"The shape is a {shape}, color is {color}, and the area is {area}");
        }
    }
}