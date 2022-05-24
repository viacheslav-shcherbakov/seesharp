// ДЗ на 3 семинар:

Console.Clear();

//Показать таблицу квадратов чисел от 1 до N
Console.WriteLine("Задание 1: Показать таблицу квадратов чисел от 1 до N");

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine() ?? "");
for (int i=1; i <= n; i++)
{
    Console.WriteLine($"Квадрат числа {i} = {i*i}");

} 
Console.WriteLine($"Это квадраты чисел от 1 до {n}");

//Найти кубы чисел от 1 до N
Console.WriteLine("Задание 2: Найти кубы чисел от 1 до N");
Console.Write("Введите число: ");
int nn = int.Parse(Console.ReadLine() ?? "");
for (int i=1; i <= nn; i++)
{
    Console.WriteLine($"Куб числа {i} = {i*i*i}");

} 
Console.WriteLine($"Это кубы чисел от 1 до {nn}");

///Найти сумму чисел от 1 до А
Console.WriteLine("Задание 3: Найти сумму чисел от 1 до А");
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine() ?? "");
int sum = 0;
for (int i=1; i <= a; i++)
{
    sum = sum + i;

} 
Console.WriteLine($"Сумма чисел от 1 до {a} = {sum}");

//Возведите число А в натуральную степень B используя цикл
Console.WriteLine("Задание 4: Возведите число А в натуральную степень B используя цикл");
Console.Write("Введите число A: ");
int aa = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите число B: ");
int bb = int.Parse(Console.ReadLine() ?? "");
int c = 1;
for (int i=1; i <= bb; i++)
{
    c = c*aa;
}
Console.WriteLine($"{aa} в степени {bb} = {c}");

//Подсчитать сумму цифр в числе
Console.WriteLine("Задание 5: Подсчитать сумму цифр в числе");
Console.Write("Введите число: ");
int x = int.Parse(Console.ReadLine() ?? "");
int y = x;
int num_sum = 0;
for (int i = 1; y > 0; i++)
{
    num_sum = num_sum + y%10;
    y = y /10;
  
}
Console.WriteLine($"Сумма цифр в числе {x} = {num_sum}.");

//Показать кубы чисел, заканчивающихся на четную цифру
Console.WriteLine("Задание 6: Показать кубы чисел, заканчивающихся на четную цифру");
Console.Write("Введите число: ");
int z = int.Parse(Console.ReadLine() ?? "");
if (z%2 == 0)
{
    Console.WriteLine($"Число {z} заканчивается на четную цифру и его куб будет = {z*z*z}");
}

else{
    Console.WriteLine($"Число {z} не заканчивается на четную цифру");
}

//Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
Console.WriteLine("Задание 7: Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран");

int[] arr = {0,1,1,0,0,0,1,1};
for(int i=0; i < arr.Length; i++)
{
    Console.Write(arr[i]);
}