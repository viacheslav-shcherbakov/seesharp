// вкадраты чисел от 1 до N
Console.WriteLine("Insert a number ");
int square = int.Parse(Console.ReadLine() ?? "");
int count = 1;
while (count < square)
{
    Console.Write(square**);
    count ++;
}
Console.WriteLine("Введите число n: ");
int n = int.Parse(Console.ReadLine() ?? "");
for (int i = 1; i <=n; i++)
{
    Console.Write($"{i * i} ");
}
