//Показать четные числа от 1 до N
Console.Clear();
int count = 1;
Console.WriteLine("Wellcome to the game: Is it even?");
Console.Write("Enter your name ->>  ");
string name = Console.ReadLine() ?? "";
Console.Write($"OK, {name}, enter the number ->>  ");
int number = int.Parse(Console.ReadLine() ?? "");
Console.Write($"Even numbers from 1 to {number} are: ->>  ");
while (count < number)
{
    if (count%2 != 0)
    {
        Console.Write(" ");
    }
else
    {
        Console.Write(count);
    }
count++;
}
Console.WriteLine();
Console.WriteLine("Play more games!");