// Удалить вторую цифру трёхзначного числа
Console.Clear();
Console.WriteLine("Wellcome to the game: Delete the second number!");
Console.Write("Enter your name ->>  ");
string name = Console.ReadLine() ?? "";
Console.Write($"OK, {name}, enter the number from 100 to 999 ->>  ");
int number = int.Parse(Console.ReadLine() ?? "");

if (number/1000 > 10 || number/ 100 == 0)
{
    Console.Write($"{number} - not a 3-digit number!");
}
else{
    int num1 = number / 100;
    int num2 = number % 10;
    Console.WriteLine($"It was {number} and now it's {num1}{num2}. How cool is this?");
}