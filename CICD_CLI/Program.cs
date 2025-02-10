using CICD_Core;

Console.WriteLine("Enter first number:");

string? s = Console.ReadLine();
int a, b;

while (true)
{
    if (!int.TryParse(s, out a))
    {
        Console.WriteLine("Error: please enter an integer");
        s = Console.ReadLine();
    }
    else
    {
        break;
    }
}

Console.WriteLine("Enter second number:");

while (true)
{
    s = Console.ReadLine();
    if (!int.TryParse(s, out b))
    {
        Console.WriteLine("Error: please enter an integer");
    }
    else
    {
        break;
    }
}

double result = Calculator.Divide(a, b);

Console.WriteLine($"{a} / {b} = {result}");
