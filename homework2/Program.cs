//По заданному номеру дня недели вывести его название
Console.Clear();

Console.Write("Enter the number from 1 to 7 ->>  ");
int weekday = int.Parse(Console.ReadLine() ?? "");
if (weekday == 1)
{
    Console.WriteLine($"{weekday} is Monday!");
}
else if (weekday == 2)
{
    Console.WriteLine($"{weekday} is Tuesday!");
}
else if (weekday == 3)
{
    Console.WriteLine($"{weekday} is Wednesday!");
}
else if (weekday == 4)
{
    Console.WriteLine($"{weekday} is Thursday!");
}
else if (weekday == 5)
{
    Console.WriteLine($"{weekday} is Friday!");
}
else if (weekday == 6)
{
    Console.WriteLine($"{weekday} is Saturday!");
}
else if (weekday == 7)
{
    Console.WriteLine($"{weekday} is Sunday!");
}
else{
     Console.WriteLine("Wrong number!");
}