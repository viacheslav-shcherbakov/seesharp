// Удалить вторую цифру трёхзначного числа
Console.Clear();
Console.WriteLine("Wellcome to the game: Delete the second number!");
Console.Write("Enter your name ->>  ");
string name = Console.ReadLine() ?? "";
Console.Write($"OK, {name}, enter the number from 100 to 999 ->>  ");
int number = int.Parse(Console.ReadLine() ?? "");
int num1 = number / 100;
int num2 = number % 10;
Console.WriteLine($"It was {number} and now it's {num1}{num2}. How cool is this?");