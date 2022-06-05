// Домашнее задание к семинару №5
Console.Clear();
// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы
Console.WriteLine("Задание 1: Найти точку пересечения двух прямых заданных уравнением \ny = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы");
Console.Write("Введите значение k1 -> ");
int k1 = int.Parse(Console.ReadLine()?? "");
Console.Write("Введите значение b1 -> ");
int b1 = int.Parse(Console.ReadLine()?? "");
Console.Write("Введите значение k2 -> ");
int k2 = int.Parse(Console.ReadLine()?? "");
Console.Write("Введите значение b2 -> ");
int b2 = int.Parse(Console.ReadLine()?? "");

if(k2 != k1) 
    Console.WriteLine($"Если b1 = {b1}, k1 = {k1}, b2 = {b2} и k2 = {k2}, то прямые пересекаются в точке ({(b2 - b1)/(k1-k2)}:{k1*(b2 - b1)/(k1-k2) + b1})");
else
    Console.WriteLine("Ошибочка вышла, нет решения...");
//-----------------------------------------------------------------------------------------
// Написать программу масштабирования фигуры
// Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой)
// например: "(0,0) (2,0) (2,2) (0,2)"
// коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
// В результате показать координаты, которые получатся.
// при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"

int CountSymbols(string str, char symbol)
{
    int count = 0;
    for(int i=0; i<str.Length; i++)
        if(str[i] == symbol)
            count++;
    return count;
}
string [] SplitString(string str, char symbol)
{
    string[] coordinates = new string[CountSymbols(str,symbol)+1];
    int amount=0;
    for(int i=0;i<str.Length;i++)
    {
        while(i < str.Length && str[i]!=symbol)
        {
            coordinates[amount]+=str[i];
            i++;
        }
        amount++;
    }
    return coordinates;
}
string Substring(string str, int startIndex, int lastIndex)
{
    string result="";
    for(int i=startIndex;i<lastIndex;i++)
        result+=str[i];
    return result;
}
int[,] ParsePoints(string[] coordinates)
{
    int[,] points = new int[coordinates.Length,2];
    for(int i=0;i<coordinates.Length;i++)
    {
        string substring = Substring(coordinates[i],1,coordinates[i].Length-1); 
        string[] pointCoordinates = SplitString(substring,','); 
        for(int j=0;j<pointCoordinates.Length;j++)
            points[i,j] = int.Parse(pointCoordinates[j]);
    }
    return points;
}
Console.WriteLine("Задание 2: Программа масштабирования фигуры");
Console.Write("Введите координаты вершин фигуры в формате (x,y), разделяя их пробелами: ");
string s = Console.ReadLine() ?? "";
if(s == null || s.Length == 0)
{
    Console.WriteLine("Вы не ввели координаты...");
    return;
}
Console.Write("Введите коэффициент масштабирования: ");
int k = int.Parse(Console.ReadLine() ?? "0");
string[] coordiates = SplitString(s,' ');
int[,] points = ParsePoints(coordiates);
Console.Write("Вот координаты после масштабирования: ");
for(int i=0;i<points.GetLength(0);i++)
    Console.Write($"({points[i,0]*k}, {points[i,1]*k}) ");
Console.WriteLine();
//-----------------------------------------------------------------------------------
// Написать программу копирования массива

void PrintArray(string[] array)
{
    for(int i=0;i<array.Length;i++)
        Console.WriteLine(array[i]);
}
Console.WriteLine("Задание 3: Программа копирования массива");
Console.Write("Введите элементы массива, разделяя их пробелами: ");
string oldarray = Console.ReadLine() ?? "";
string[] newarray = SplitString(oldarray, ' '); // Использовал функцию, котораю уже была в Задании 2
Console.WriteLine("Новый массив создан как копия под именем newarray: ");
PrintArray(newarray);