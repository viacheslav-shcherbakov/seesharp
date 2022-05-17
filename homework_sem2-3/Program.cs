// Задать номер четверти, показать диапазоны для возможных координат
Console.Clear();
Console.WriteLine("Оси координат разделяют плоскость на 4 четверти\n где первая - положительные значения X и Y");
Console.WriteLine("Хотите узнать к какой четверти относится точка на плоскости?\nВведите 'y', чтобы продолжить, или 'n' для выхода");
string answer = Console.ReadLine() ?? "";
if(answer=="y")
{
    Console.Write("Введите значение по оси Х ->> ");
    int x = int.Parse(Console.ReadLine() ?? "");
    Console.Write("Введите значение по оси Y ->> ");
    int y = int.Parse(Console.ReadLine() ?? "");
    if (x>0 && y>0)
    {
        Console.WriteLine($"Точка ({x}:{y}) расположена в первой четверти");
    }
    else if (x>0 && y<0)
    {
        Console.WriteLine($"Точка ({x}:{y}) расположена во второй четверти");
    }
    else if (x<0 && y<0)
    {
        Console.WriteLine($"Точка ({x}:{y}) расположена в третьей четверти");
    }
    else if (x<0 && y>0)
    {
        Console.WriteLine($"Точка ({x}:{y}) расположена в четвертой четверти");
    }
    else
    {
        Console.WriteLine($"Точка ({x}:{y}) расположена на одной из осей кооридинат и не относится к четвертям");
    }
}
else if(answer=="n")
{
    Console.WriteLine("Тогда... Пока!");
}
else
{
    Console.WriteLine("Извините, команда не опознана. Программа будет прекращена!");
}
