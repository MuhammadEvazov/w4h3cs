using Task3;
Console.Write("Enter first number: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the operation: ");
char s = Convert.ToChar(Console.ReadLine()!);

Console.Write("Enter second number: ");
double b = Convert.ToDouble(Console.ReadLine());


while (true)
{
    if (s == '+')
    {
        System.Console.WriteLine(Calculate.Add(a, b));
    }
    else if (s == '-')
    {
        System.Console.WriteLine(Calculate.Subtract(a, b));
    }
    else if (s == '*')
    {
        System.Console.WriteLine(Calculate.Multiply(a, b));
    }
    else if (s == '/')
    {
        System.Console.WriteLine(Calculate.Divide(a, b));
    }
    else
    {
        System.Console.WriteLine("Invalid operation");
    }
    return;
}