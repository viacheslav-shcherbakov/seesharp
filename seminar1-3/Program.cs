// Программа проверяет пятизначное число на палиндромом.
Console.WriteLine("Enter a 5-digit number");
int x = int.Parse(Console.ReadLine() ?? "");
if (x/10000 == x%10 && x / 1000 % 10 == x /10 % 10)
    Console.WriteLine("Palindrom");
else
    Console.WriteLine("not palindrom");