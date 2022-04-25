// Выяснить является ли число чётным
Console.Clear(); // С чистой консоли лучше видно
// Для этого ищем остаток от деления на 2
int count = 0;
int wins = 0;
Console.WriteLine("Wellcome to the game: Is it even?");
Console.Write("Enter your name ->>  ");
string name = Console.ReadLine() ?? "";
Console.Write($"OK, {name}, enter the number ->>  ");
int number = int.Parse(Console.ReadLine() ?? "");
if (number%2 != 0) // Берем остаток от деления на 2, если остаток не 0 - то нечетное
    {
        Console.WriteLine($"{name}, {number} is not even!");
    }
else // В другом случае (т.е. если 0) - четное
    {
        Console.WriteLine($"{name}, {number} is even!");
    }
Console.WriteLine($"Play more games, {name}!"); 
// Выводим в консоль, а уже хочется в какое-то окошко...