Console.Write("Enter first number to summ: ");
int numberA = int.Parse(Console.ReadLine() ?? "");
Console.Write("Enter second number to summ: ");
int numberB = int.Parse(Console.ReadLine() ?? "");
int summ = numberA + numberB;
Console.WriteLine("The summ is " + summ);
