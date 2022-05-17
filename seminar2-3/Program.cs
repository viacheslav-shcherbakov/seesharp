// Определить количество цифр в числе
Console.Clear();

Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine() ?? "");
int i = 0;
while (a>0)
{
    a = a/10;
    i++;
}
// решение с переводом в строку
//Console.WriteLine("Insert ur number");
//int number = int.Parse(Console.ReadLine());
//string c;
//c = number.ToString();
//int c1 = c.Length;
//Console.WriteLine($"Digits in {number} is {c1}");

//int i=0;
//for (i=0; a>0; i++)
//{
 //   a = a/10;
//}
Console.Write($"Количество цифр в числе =  {i} ");