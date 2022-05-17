//Найти расстояние между точками в пространстве 2D/3D
Console.Clear();
Console.WriteLine("Задача №4: Найти расстояние между точками в пространстве 2D/3D");
Console.WriteLine("Введите количество измерений (2 или 3) ->>");
int dimension = int.Parse(Console.ReadLine() ?? "");
if(dimension==2)
{
    Console.Write("Введите первое значение по оси Х ->> ");
    int x1 = int.Parse(Console.ReadLine() ?? "");
    Console.Write("Введите первое значение по оси Y ->> ");
    int y1 = int.Parse(Console.ReadLine() ?? "");
    Console.Write("Введите второе значение по оси Х ->> ");
    int x2 = int.Parse(Console.ReadLine() ?? "");
    Console.Write("Введите второе значение по оси Y ->> ");
    int y2 = int.Parse(Console.ReadLine() ?? "");
    double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    Console.Write($"Расстояние между этими точками = {distance}");
}
else if(dimension==3)
{
    Console.Write("Введите первое значение по оси Х ->> ");
    int x1 = int.Parse(Console.ReadLine() ?? "");
    Console.Write("Введите первое значение по оси Y ->> ");
    int y1 = int.Parse(Console.ReadLine() ?? "");
    Console.Write("Введите первое значение по оси Z ->> ");
    int z1 = int.Parse(Console.ReadLine() ?? "");
    Console.Write("Введите второе значение по оси Х ->> ");
    int x2 = int.Parse(Console.ReadLine() ?? "");
    Console.Write("Введите второе значение по оси Y ->> ");
    int y2 = int.Parse(Console.ReadLine() ?? "");
    Console.Write("Введите второе значение по оси Z ->> ");
    int z2 = int.Parse(Console.ReadLine() ?? "");
    double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    Console.Write($"Расстояние между этими точками = {distance}");
}
else
{
    Console.Write("Вы ввели что-то не то...");
}
