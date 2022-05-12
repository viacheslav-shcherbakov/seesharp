// Показать вторую цифру трёхзначного числа
Console.Clear();
Console.Write("Введите трехзначное число -> ");
int n = int.Parse(Console.ReadLine() ?? "");
if (n/1000 > 10 || n/ 100 == 0)
{
    Console.Write($"{n} - это не трехзначное число!");

}
else{
    Console.Write("Вторая цифра чила -> ");
    Console.WriteLine((n /10) % 10);
}