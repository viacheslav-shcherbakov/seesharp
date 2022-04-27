//По двум заданным числам проверять является ли первое квадратом второго
// игровой формат не надоедает
Console.Clear();
int[] squareArray = new int [6]{ 25, 36, 64, 9, 81, 16}; // С массивом гораздо интерснее
int count = 0; // Это подсчет раундов игры
int wins = 0; // Счёт побед
Console.WriteLine("Wellcome to the game: Guess the square root!");
Console.Write("Enter your name ->>  ");
string name = Console.ReadLine() ?? "";
while (count < 6) // Потому что начинается с нуля
    {
    Console.Write($"OK, {name}, here is a number: -> ");
    Console.WriteLine(squareArray[count]); // Перебираем массив по порядку
    Console.Write("Enter the square root ->>  ");
    int number = int.Parse(Console.ReadLine() ?? "");
    if (number*number == squareArray[count]) // Проверяем равно ли квадрату
        {
            Console.WriteLine("You win!");
            count++;
            wins++; // Засчитываем победу
        }
    else
        {
            Console.WriteLine("You LOOSE!");
            count++;
        }
    }
Console.WriteLine($"You have won {wins} times!"); // Объявляем счет

// Взял игровую форму, т.к. параллельно учусь на др.курсах, где игры - основной пример.
// К тому же - это веселее))