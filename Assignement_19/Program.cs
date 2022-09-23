Console.Clear();

Console.WriteLine("Enter 5-digit number");
int number = int.Parse(Console.ReadLine()!);

if ((number / 10000 < 1) ^ (number / 10000 > 9))
{
    Console.WriteLine("Wrong number");
}
else if (number / 10000 % 10 != number % 10)
{
    Console.WriteLine("No, it's not a palindrome");
}
else if (number / 1000 % 10 != number / 10 % 10)
{
    Console.WriteLine("No, it's not a palindrome");
}
else
{
    Console.WriteLine("Yes, it's a palindrome");
}
