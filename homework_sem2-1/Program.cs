// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.Clear();
Console.Write("Введите число от 1 до 7 ->> ");
int day_week_num = int.Parse(Console.ReadLine() ?? "0");
if (day_week_num >=6)
{
    Console.WriteLine($"{day_week_num}-ый день недели - это выходной");
}
else
{
    Console.WriteLine($"{day_week_num}-ый день недели - это не выходной");
}
