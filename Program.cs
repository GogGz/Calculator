namespace HomeworkNewYear;
class Program
{
    static void Main(string[] args)
    {
        int a;
        int b;

        repeat:
        Console.Write("Enter number a: ");
        a = int.Parse(Console.ReadLine());
        Console.Write("Enter number b: ");
        b = int.Parse(Console.ReadLine());


        Console.WriteLine(a + " + " + b + " = " + Sum(a, b));
        Console.WriteLine(a + " - " + b + " = " + Sub(a, b));
        Console.WriteLine(a + " * " + b + " = " + Mult(a, b));
        try
        {
            Console.WriteLine(a + " / " + b + " = " + Div(a, b));

        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine(e.Message);
        }

        goto repeat;
    }

    public static int Sum(int a, int b)
    {
        return a + b;
    }

    public static int Sub(int a, int b)
    {
        return a - b;
    }

    public static int Mult(int a, int b)
    {
        return a * b;
    }

    public static float Div(int a, int b)
    {
        return (float)a / b;
    }

}