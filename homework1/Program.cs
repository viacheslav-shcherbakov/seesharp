//По двум заданным числам проверять является ли первое квадратом второго
// игровой формат не надоедает
Console.Clear();

Console.Write("Enter first number ");
int firstnum = int.Parse(Console.ReadLine() ?? "");
Console.Write("Enter second number ");
int secondnum = int.Parse(Console.ReadLine() ?? "");

if (secondnum*secondnum == firstnum) // Проверяем равно ли квадрату
    {
        Console.WriteLine("It is square!");
    }
else
    {
        Console.WriteLine("It's not a square!");
    }