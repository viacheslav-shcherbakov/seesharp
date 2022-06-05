// В матрице чисел найти сумму элементов главной диагонали

Console.Clear();

void FillArray(int[,] matr)
{
    for (int i=0; i<matr.GetLength(0); i++)
    {
        for(int j=0; j<matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(0,99);          
        }
    }
}
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
//void SummDiagonalMatrix(int[] matr)
//{
//   int sum = 0;
//    for (int i=0; i<matr.GetLength(0); i++)
//    {
//        for(int j=0; j<matr.GetLength(1); j++)
//        {
//            if (i==j)
//            {
//                sum += matr[i,j];
//            };
//        }
//    Console.WriteLine(sum);
//    }
//}
//Console.WriteLine("Введите размер матрицы: ");
//int m = int.Parse(Console.ReadLine()?? "");
//int[,] matrix = new int[m,m];
//FillArray(matrix);
//PrintArray(matrix);



// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов
double [] MediumOfColumn(int[,] matr)
{
    double [] medium = new double [matr.GetLength(1)];
    for (int i=0; i<matr.GetLength(1); i++)
    {    
        double sum = 0;
        for(int j=0; j<matr.GetLength(0); j++)
        {
            sum = sum + matr[j,i];                        
        }
        medium [i] = sum / matr.GetLength(0);
    }
    return medium;
}

void PrintResult(double[] array)
{
    for(int i =0; i<array.GetLength(0); i++)
        Console.Write($"{array[i]} ");
}

Console.WriteLine("Введите m: ");
int m = int.Parse(Console.ReadLine()?? "");
Console.WriteLine("Введите n: ");
int n = int.Parse(Console.ReadLine()?? "");
int[,] matrix = new int[m,n];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine("Средние по столбцам:");

PrintResult(MediumOfColumn(matrix));