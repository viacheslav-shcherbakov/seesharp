// Найти третью цифру числа или сообщить, что её нет
Console.Clear();
Console.Write("Enter the number -> ");
int number = int.Parse(Console.ReadLine() ?? "");
if (number / 100 > 1 && number <1000 && number >= 100)
{
    Console.WriteLine($"The result is {number %10}");
}
else{
    Console.WriteLine("There is no third number at all! \n May be because your number is less then 100 or bigger than 999?");
}
