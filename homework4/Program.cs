//Показать четные числа от 1 до N
Console.Clear();
int count = 1; // Переменная, чтобы перебирать варианты
Console.WriteLine("Wellcome to the game: Is it even?");
Console.Write("Enter your name ->>  ");
string name = Console.ReadLine() ?? "";
string exitWord = "";
while (!exitWord.Equals("exit"))
{
    Console.Write($"OK, {name}, enter the number ->>  ");
    int number = int.Parse(Console.ReadLine() ?? "");
    Console.Write($"Even numbers from 1 to {number} are: ->>  "); // Выводить будем в одну строку
    while (count < number)
    {
        if (count % 2 != 0)
        {
            Console.Write(" "); // Вместо нечетного числа - пробел
        }
        else
        {
            Console.Write(count);
        }
        count++;
    }
    Console.WriteLine();
    Console.WriteLine();
    Console.Write("If you want to play again, press Enter. If not, then input the word exit, and press Enter: ");
    exitWord = Console.ReadLine() ?? "";
}
Console.WriteLine(); // Отступаем строку. Так красивее))
Console.WriteLine("Play more games!");