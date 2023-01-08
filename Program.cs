namespace HomeworkNewYear;
class Program
{
    static void Main(string[] args)
    {
        int a;
        int b;
        char ch;
    repeat:
        try
        {
            Console.Write("Enter 1st number:");
            a = int.Parse(Console.ReadLine());
            Console.Write("+ , - , * , / ");
            ch = char.Parse(Console.ReadLine());

            Console.Write("Enter 2nd number:");
            b = int.Parse(Console.ReadLine());


            switch (ch)
            {
                case '+':
                    Console.WriteLine(a + " + " + b + " = " + (a + b));
                    break;
                case '-':
                    Console.WriteLine(a + " - " + b + " = " + (a - b));
                    break;

                case '*':
                    Console.WriteLine(a + " + " + b + " = " + (a * b));
                    break;
                case '/':
                    try
                    {
                        Console.WriteLine(float.Parse(a + " + " + b + " = " + (a / b)));
                    }
                    catch (DivideByZeroException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    break;
            }
        }
        catch (System.FormatException e)
        {
            Console.WriteLine(e.Message);
        }
        goto repeat;
    }
}