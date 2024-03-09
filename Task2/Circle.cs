using System.Net.NetworkInformation;

namespace Task2;

public static class Circle
{
    public static double Pi=3.14;
    public static void CalcCircleArea(double radius)
    {
        double S;
        S=Pi*radius*radius;
        System.Console.WriteLine(S);
    }
        public static void  CalcCirclePerimeter(double radius)
    {
        double P;
        P=2*Pi*radius;
        System.Console.WriteLine(P);
    }
}
