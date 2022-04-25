Console.WriteLine("Введите диапазон чисел");
int n2 = int.Parse(Console.ReadLine());
int n1 = -n2;
Console.WriteLine(n1);
while (n1<= n2)
{
    Console.Write(n1);
    Console.Write(" ");
    n1 ++;
}