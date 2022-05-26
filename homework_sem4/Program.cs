//Домашнее задание к семинару 4
Console.Clear();

// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
Console.WriteLine("Задание 1: Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран");
int[] arr = {0,1,1,0,0,0,1,1};
for(int i=0; i < arr.Length; i++)
{
    Console.Write(arr[i]);
}
Console.WriteLine();

//Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива
Console.WriteLine("Задание 2: Задать массив из 12 элементов, заполненных числами из [0,9]. \nНайти сумму положительных/отрицательных элементов массива");
int[] array = new int[12];
Random r = new Random();
Console.Write("Наш массив: ");
for (int i = 0; i < array.Length; i++)
{
    array[i] = r.Next(0, 9);
    Console.Write(array[i] + " ");
}
int sum = 0;
Console.WriteLine();
for (int i=0; i < array.Length; i++)
{
    sum = sum + array[i];
} 
Console.WriteLine($"Сумма элементов массива = {sum}");

//Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
Console.WriteLine("Задание 3: Задать массив, заполнить случайными положительными трёхзначными числами. \n Показать количество нечетных/четных чисел.");
int[] array_3 = new int[10];
Random rand = new Random();
Console.Write("Наш массив: ");
for (int i = 0; i < array_3.Length; i++)
{
    array_3[i] = rand.Next(100, 999);
    Console.Write(array_3[i] + " ");
}
int even = 0;
int uneven = 0;
Console.WriteLine();
for (int i=0; i < array_3.Length; i++)
{
    if(array_3[i]%2 == 0)
    {
        even++;
    }
    else
    {
        uneven++;
    }
} 
Console.WriteLine($"Нечетных - {uneven}, четных - {even}");

//В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
Console.WriteLine("Задание 4: В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99].");
int[] array_4 = new int[123];
Random rand_4 = new Random();
Console.Write("Наш массив: ");
int num = 0;
for (int i = 0; i < array_4.Length; i++)
{
    array_4[i] = rand_4.Next(0, 999);
    Console.Write(array_4[i] + " ");
}
Console.WriteLine();
for (int i=0; i < array_4.Length; i++)
{
    if(array_4[i] >= 10 && array_4[i] <= 99 )
    {
        num++;
    }
} 
Console.WriteLine($"Чисел в диапазоне от 10 до 99 = {num}");

//Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
Console.WriteLine("Задание 5: Найти произведение пар чисел в одномерном массиве. \nПарой считаем первый и последний элемент, второй и предпоследний и т.д");
int[] array_5 = new int[10];
Random rand_5 = new Random();
Console.Write("Наш массив: ");
for (int i = 0; i < array_5.Length; i++)
{
    array_5[i] = rand_5.Next(0, 9);
    Console.Write(array_5[i] + " ");
}
Console.WriteLine("Произведения пар: ");
int half = array_5.Length / 2;

for (int i=1; i <= half; i++)
{
    Console.Write(array_5[i-1] * array_5[array_5.Length-i] + " ");
} 