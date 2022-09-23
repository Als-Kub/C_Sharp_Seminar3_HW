Console.Clear();

Console.WriteLine("Enter a number");

int number = int.Parse(Console.ReadLine()!);

for (int i = 1; i <= number; i++)
{
    int cubicNumber = i * i * i;

    if (i == number)
    {
        Console.Write($"{cubicNumber}");
    }
    else
    {
        Console.Write($"{cubicNumber}, ");
    }
}
