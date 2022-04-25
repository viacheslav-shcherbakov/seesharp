// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
Console.Clear();
Console.WriteLine("Wellcome to the game: Whoe's bigger?");
Console.Write("Enter your name ->>  ");
string name = Console.ReadLine() ?? "";
Console.Write($"OK, {name}, enter the number from 10 to 99 ->>  ");
int number = int.Parse(Console.ReadLine() ?? "");
int num1 = number / 10;
int num2 = number % 10;
if (num1 > num2)
{
    Console.WriteLine($"The biggest number in {number} is: ->>  {num1}");
}
else
{
    Console.WriteLine($"The biggest number in {number} is: ->>  {num2}");
}
Console.Write($"Play more games, {name}");