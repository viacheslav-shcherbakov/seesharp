// По двум заданным числам проверять является ли одно квадратом другого
Console.Clear();
Console.Write("Введите первое число ->> ");
int first_num = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите второе число ->> ");
int second_num = int.Parse(Console.ReadLine() ?? "0");
if (first_num == second_num*second_num)
{
    Console.WriteLine($"{first_num} - это {second_num} возведенное в квадрат");
}
else if (first_num*first_num == second_num)
{
    Console.WriteLine($"{second_num} - это {first_num} возведенное в квадрат");
}
else
{
    Console.WriteLine("Эти числа не связаны 'квадратными' отношениями ))");
}
