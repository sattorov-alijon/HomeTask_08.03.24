namespace Task3;

public static class MathFunction
{
    public static void Summ(int a, int b)
    {
        System.Console.WriteLine(a + b);
    }
    public static void Subtract(int a, int b)
    {
        if (a > b)
        {
            System.Console.WriteLine(a - b);
        }
        else
        {
            System.Console.WriteLine(b - a);

        }
    }
    public static void Multiply(int a, int b)
    {
        System.Console.WriteLine(a * b);
    }
    public static void Divide(int a, int b)
    {
        System.Console.WriteLine(a / (double)b);
    }
}