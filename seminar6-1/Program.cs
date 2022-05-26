// Матрица
//В двумерном массиве n×k заменить четные элементы на противоположные

Console.Clear();
void PrintArray(int[,] matr)
{
    for (int i=0; i<matr.GetLength(0); i++)
    {
        for(int j=0; j<matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i,j]} ");
        }
    Console.WriteLine();
    }
}
void FillArray(int[,] matr)
{
    for (int i=0; i<matr.GetLength(0); i++)
    {
        for(int j=0; j<matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(-99,99);          
        }
    }
}
void ChangeArray(int[,] matr)
{
    for (int i=0; i<matr.GetLength(0); i++)
    {
        for(int j=0; j<matr.GetLength(1); j++)
        {
            if(matr[i,j]%2==0)
            {
                matr[i,j] = - matr[i,j];
            }            
        }
    }
}
//В двумерном массиве показать позицию числа, заданного пользователем или указать, что такого элемента нет
bool IsInArray(int[,] matr, int number)
{
    for (int i=0; i<matr.GetLength(0); i++)
        for(int j=0; j<matr.GetLength(1); j++)
            if(matr[i,j]==number) return true; 
    return false;
}

Console.WriteLine("Введите число m: ");
int m = int.Parse(Console.ReadLine()?? "");
Console.WriteLine("Введите число n: ");
int n = int.Parse(Console.ReadLine()?? "");
Console.WriteLine("Какое число искать? ");
int number = int.Parse(Console.ReadLine()?? "");

int[,] matrix = new int[m,n];
FillArray(matrix);
Console.WriteLine("Начальный массив: ");
PrintArray(matrix);
if(IsInArray(matrix,number)==true) Console.WriteLine("Нашел!");
else Console.WriteLine("Не нашел!");
