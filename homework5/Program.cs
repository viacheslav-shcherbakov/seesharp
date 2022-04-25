// Показать вторую цифру трёхзначного числа
Console.Write("Введите трехзначное число -> ");
int n = int.Parse(Console.ReadLine() ?? "");
Console.Write("Вторая цифра чила -> ");
Console.WriteLine((n /10) % 10);