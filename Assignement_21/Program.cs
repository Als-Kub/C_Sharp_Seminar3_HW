Console.Clear();

Console.WriteLine("Enter X coordinate of the First point");
int x1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter Y coordinate of the First point");
int y1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter Z coordinate of the First point");
int z1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter X coordinate of the Second point");
int x2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter Y coordinate of the Second point");
int y2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter Z coordinate of the Second point");
int z2 = int.Parse(Console.ReadLine()!);

double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

Console.WriteLine($"Distance = {distance.ToString("#.00")}");

