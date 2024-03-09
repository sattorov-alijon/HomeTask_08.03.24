namespace Task2;

public static class Rectangle
{

    public static void CalcRectangleArea(double length, double width)
    {
        System.Console.WriteLine(length*width);
    }
        public static void  CalcRectanglePerimeter(double length, double width)
        {
         System.Console.WriteLine(2*(width+length));
        }
}
