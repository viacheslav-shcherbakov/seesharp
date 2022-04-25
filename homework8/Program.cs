// Выяснить, кратно ли число заданному, если нет, вывести остаток.
Console.Clear();
int number = 3;
Console.Write("Enter a number -> ");
int userNumber = int.Parse(Console.ReadLine() ?? "");

if (userNumber % number == 0)
{
    Console.WriteLine($"Number {userNumber} is devisible by {number}");
}
else 
{
    Console.Write($"Number {userNumber} is not devisible by {number}. The remainder is " + userNumber % number);
}