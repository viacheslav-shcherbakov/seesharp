// Домашнее задание к семинару №6
// Показать двумерный массив размером m×n заполненный вещественными числами
Console.Clear();
void FillMatrix(double[,] matrix)
{
    for (int i=0; i<matrix.GetLength(0); i++)
        for(int j=0; j<matrix.GetLength(1); j++)
            matrix[i,j] = new Random().NextDouble();          
}
void PrintMatrix(double[,] matrix)
{
    for (int i=0; i<matrix.GetLength(0); i++)
    {
        for(int j=0; j<matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
    Console.WriteLine();
    }
}
Console.WriteLine("Задание 1: Показать двумерный массив размером m×n заполненный вещественными числами");
Console.WriteLine("Введите число количество строк: ");
int m = int.Parse(Console.ReadLine()?? "");
Console.WriteLine("Введите число количество столбцов: ");
int n = int.Parse(Console.ReadLine()?? "");
double[,] matrix = new double[m,n];
FillMatrix(matrix);
Console.WriteLine("Вот, что вышло: ");
PrintMatrix(matrix);

//-------------------------------------------------------------
// Задать двумерный массив следующим правилом: Aₘₙ = m+n

void ChangeMatrix(double[,] matrix)
{
    for (int i=0; i<matrix.GetLength(0); i++)
        for(int j=0; j<matrix.GetLength(1); j++)
            matrix[i,j] = i+j;
}
Console.WriteLine("Задание 2: Задать двумерный массив следующим правилом: Aₘₙ = m+n");
Console.WriteLine("Введите число количество строк: ");
int m1 = int.Parse(Console.ReadLine()?? "");
Console.WriteLine("Введите число количество столбцов: ");
int n1 = int.Parse(Console.ReadLine()?? "");
double[,] matrix2 = new double[m1,n1];
FillMatrix(matrix2);
ChangeMatrix(matrix2);
Console.WriteLine("Вот, что вышло: ");
PrintMatrix(matrix2);

//------------------------------------------------------------------------------------
// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
void ChangeEvenToSquare(double[,] matrix)
{
    for (int i=1; i<matrix.GetLength(0); )
    {
        for(int j=1; j<matrix.GetLength(1); )
        {
            matrix[i,j] = matrix[i,j]*matrix[i,j];
            j += 2;
        }
        i += 2;
    }
}
ChangeEvenToSquare(matrix2);
Console.WriteLine("Задание 3: В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты");
Console.WriteLine("Вот это квадраты из предыдущей матрицы: ");
PrintMatrix(matrix2);