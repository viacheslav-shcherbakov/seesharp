// Определить, присутствует ли в массиве некоторое число
Console.Clear();
int [] arr = {1,2,3,4,5,7};
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()?? "") ;
string result = "";
foreach(int var in arr)
{
    if(var ==  number)
    {
        result = "Есть!";
        break;
    }
    else{
        result = "Нет";
    }
}
Console.WriteLine(result);