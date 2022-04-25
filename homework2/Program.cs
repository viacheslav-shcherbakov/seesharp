//По заданному номеру дня недели вывести его название
Console.Clear();
string[] dayofweekArray = new string [7]{ "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Satturday", "Sunday"}; 
//Взял массив, чтобы сократить количество строчек и переменных
Console.WriteLine("Wellcome to the game: Which day of the week!"); // Опять игровой формат - пока не надоело
Console.Write("Enter your name ->>  ");
string name = Console.ReadLine() ?? "";
Console.Write($"OK, {name}, enter a number from 1 to 7: -> ");
int number = int.Parse(Console.ReadLine() ?? "");
if (number < 1 && number > 7) // Отслеживаем ошибки
{
    Console.WriteLine($"{number} is a wrong number!");
}
else{
    Console.WriteLine("It's " + dayofweekArray[number - 1] + " !"); // Вычитаю один, т.к. массив считается с 0
}