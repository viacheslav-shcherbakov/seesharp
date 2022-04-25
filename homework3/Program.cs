// Выяснить является ли число чётным
// Для этого ищем остаток от деления на 2
Console.Clear();
int count = 0;
int wins = 0;
Console.WriteLine("Wellcome to the game: Is it even?");
Console.Write("Enter your name ->>  ");
string name = Console.ReadLine() ?? "";
Console.Write($"OK, {name}, enter the number ->>  ");
int number = int.Parse(Console.ReadLine() ?? "");
if (number%2 != 0)
    {
        Console.WriteLine($"{number} is not even!");
    }
else
    {
        Console.WriteLine($"{number} is even!");
    }
Console.WriteLine("Play more games!");