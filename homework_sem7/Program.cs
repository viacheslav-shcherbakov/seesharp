// Написать программу, которая обменивает элементы первой строки и последней строки
Console.Clear();
Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()?? "0");
Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()?? "0");
int[,] matrix = new int[rows,columns];

void FillMatrix(int[,] matrix)
{
    for (int i=0; i<rows; i++)
        for(int j=0; j<columns; j++)
            matrix[i,j] = new Random().Next(10,100);          
}
void PrintMatrix(int[,] matrix)
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
void ChangeLines(int[,] matrix)
{
    for (int i=0; i<columns; i++)
    {
        int firstLine = 0;
        int lastLine = 0;
        firstLine = matrix[0,i];
        lastLine = matrix[rows-1,i];
        matrix[0,i] = lastLine;
        matrix[rows-1,i] = firstLine;
    }
}
FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine("Поменяем местами верхнюю и нижнюю строки...");
ChangeLines(matrix);
PrintMatrix(matrix);


// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.

void ArrangeLines(int[,] matrix)
{
    for(int i=0; i<rows; i++)
    {
        for(int j=0; j<columns-1; j++)
        {
            for(int k=0; k<columns-j-1; k++)
            {
                int max = 0;
                int min = 0;
                if(matrix[i,k]>matrix[i,k+1])
                {
                    max = matrix[i,k];
                    min = matrix[i,k+1];
                    matrix[i,k] = min;
                    matrix[i,k+1] = max;
                }
            }  
        }
    }
}
Console.WriteLine("А теперь упорядочим строки по возрастанию...");
ArrangeLines(matrix);
PrintMatrix(matrix);

// Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, 
// что это невозможно (в случае, если матрица не квадратная).
void RotateMatrix(int[,] matrix)
{
    if(rows!=columns)
    {
        Console.WriteLine("Матрица не квадратная, - повернуть не получится...");
    } 
    else 
    {
        int[,] rotatedmatrix = new int [rows,columns];
        for (int i=0; i<rows; i++)
        {        
            for(int j=0; j<columns; j++)
            {
                rotatedmatrix[j,i] = matrix[i,j];
            }
        }
        for (int i=0; i<rows; i++)
        {        
            for(int j=0; j<columns; j++)
            {
                matrix[i,j] = rotatedmatrix[i,j];
            }
        }
    }
}
Console.WriteLine("А теперь поменяем местами строки и столбцы (если получится):...");
RotateMatrix(matrix);
PrintMatrix(matrix);

// В прямоугольной матрице найти строку с наименьшей суммой элементов.
int[,] MinSumRow(int[,] matrix)
{
    int sum = 0;
    int [] sumarray = new int[rows];
    for (int i=0; i<rows; i++)
    {        
        for(int j=0; j<columns; j++)
        {
            sum += matrix[i,j];
        }
        sumarray[i] = sum;
        sum = 0;
    }
    int minsum = sumarray[0];
    int minrownumber = 0;
    for (int i=1; i<rows-1; i++)
    {
        if(sumarray[i]<minsum)
        {
            minsum = sumarray[i];
            minrownumber = i;
        }
    }
    int[,] minsumrowmatrix = new int[1,columns];
    for (int i=0; i<columns; i++)
    {        
        minsumrowmatrix[0,i] = matrix[minrownumber,i];
    }
    return minsumrowmatrix;
}
Console.WriteLine("Вот строка с минимальной суммой элементов...");
PrintMatrix(MinSumRow(matrix));