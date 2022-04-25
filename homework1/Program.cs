//По двум заданным числам проверять является ли первое квадратом второго
// игровой формат не надоедает
Console.Clear();
int[] squareArray = new int [6]{ 25, 36, 64, 9, 81, 16};
int count = 0;
int wins = 0;
Console.WriteLine("Wellcome to the 'Guess the square root!' game");
Console.Write("Enter your name here ->>  ");
string name = Console.ReadLine() ?? "";
while (count < 6)
    {
    Console.Write($"OK, {name}, here is a number: -> ");
    Console.WriteLine(squareArray[count]);
    Console.Write("Enter the square root ->>  ");
    int number = int.Parse(Console.ReadLine() ?? "");
    if (number*number == squareArray[count])
        {
            Console.WriteLine("You win!");
            count++;
            wins++;
        }
    else
        {
            Console.WriteLine("You LOOSE!");
            count++;
        }
    }
Console.WriteLine($"You have won {wins} times!");