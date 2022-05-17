// Написать программу вычисления произведения чисел от 1 до N
Console.Clear();

Console.WriteLine("Введите число A: ");
int num = int.Parse(Console.ReadLine() ?? "");
int product = 1;
int num1 =1;
while (num1<=num)
{
    product = num1*product;
    num1++;
}
Console.Write($"Произведение чисел от 1 до {num} = {product} ");