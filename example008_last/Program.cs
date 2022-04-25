//Console.Write("Введите трехзначное число -> ");
//int n = int.Parse(Console.ReadLine());
//Console.Write("Последняя цифра чила -> ");
//Console.WriteLine(n % 10);
Console.Write("What is your name? -> ");
string name = Console.ReadLine() ?? "";
Console.Write("How old are you? -> ");
int age = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"Your name is {name}. Your age is {age} years old.");
