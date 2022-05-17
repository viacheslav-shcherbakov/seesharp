// Сумма от 1 до A
Console.Clear();

Console.WriteLine("Введите число A: ");
int a = int.Parse(Console.ReadLine() ?? "");
int sum = 0;
for (int i = 1; i <=a; i++)
{
    sum = i+sum;
   
}
Console.Write($"Сумма чисел от 1 до {a} = {sum} ");