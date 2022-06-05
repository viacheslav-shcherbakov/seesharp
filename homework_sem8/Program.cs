// Найти произведение двух матриц

void FillMatrix(int[,] matrix)
{
    for (int i=0; i<matrix.GetLength(0); i++)
        for(int j=0; j<matrix.GetLength(1); j++)
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
int [,] GetMultipliedMatrix(int[,] firstmatrix, int[,] secondmatrix)
{
    int[,] multipliedmatrix = new int[firstmatrix.GetLength(0), secondmatrix.GetLength(1)];
    try
    {       
        for (int i=0; i<firstmatrix.GetLength(0); i++)
            for(int j=0; j<secondmatrix.GetLength(1); j++)              
                for (int k=0; k <firstmatrix.GetLength(1); k++)
                    multipliedmatrix[i,j] += firstmatrix[i,k]*secondmatrix[k,j];                     
    }
    catch (System.IndexOutOfRangeException)
    {
        Console.WriteLine("Не могу перемножить несогласованные матрицы");
    }
    return multipliedmatrix;
}
Console.Clear();
Console.WriteLine("Задание №1. Найти произведение двух матриц. ");
Console.WriteLine("--------------------------------------------");
Console.Write("Введите количество строк первой матрицы: ");
int a = int.Parse(Console.ReadLine()?? "0");
Console.Write("Введите количество столбцов первой матрицы: ");
int b = int.Parse(Console.ReadLine()?? "0");
Console.Write("Введите количество строк второй матрицы: ");
int c = int.Parse(Console.ReadLine()?? "0");
Console.Write("Введите количество столбцов второй матрицы: ");
int d = int.Parse(Console.ReadLine()?? "0");
int[,] firstmatrix = new int[a,b];
int[,] secondmatrix = new int[c,d];
FillMatrix(firstmatrix);
FillMatrix(secondmatrix);
Console.WriteLine("Это первая матрица: ");
PrintMatrix(firstmatrix);
Console.WriteLine("Это вторая матрица: ");
PrintMatrix(secondmatrix);
Console.WriteLine("А вот и произведение двух матриц: ");
PrintMatrix(GetMultipliedMatrix(firstmatrix, secondmatrix));
Console.Write("Нажмите на ввод, перейти к следующей задаче");
Console.ReadLine();
Console.Clear();



// В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.
Console.WriteLine("Задание №2. В двумерном массиве целых чисел. Удалить строку и столбец, \nна пересечении которых расположен наименьший элемент. ");
Console.WriteLine("-----------------------------------------------------------------------");
int [] coordinates = new int[2];
void MinCoordinates(int[,] matrix)
{
    int min = matrix[0,0];
    for (int i=0; i<matrix.GetLength(0); i++)
    {
        for(int j=0; j<matrix.GetLength(1); j++)
        {
            if(matrix[i,j]<min)
            {
                min = matrix[i,j]; 
                coordinates[0] = i; 
                coordinates[1] = j;
            }            
        }
    }      
}
int[,] DeleteMinCross(int[,] matrix)
{
    int[,] tempmatrix = new int[matrix.GetLength(0)-1, matrix.GetLength(1)-1];
    for (int i=0; i<matrix.GetLength(0); i++)
    {
        for(int j=0; j<matrix.GetLength(1); j++)
        {
            if(i<coordinates[0])
            {
                if(j<coordinates[1]) tempmatrix[i,j] = matrix[i,j];
                if(j>coordinates[1]) tempmatrix[i,j-1] = matrix[i,j];
            }    
            if(i>coordinates[0])
            {
                if(j<coordinates[1]) tempmatrix[i-1,j] = matrix[i,j];
                if(j>coordinates[1]) tempmatrix[i-1,j-1] = matrix[i,j];
            }      
        }
    }     
    return tempmatrix;
}
PrintMatrix(firstmatrix);
Console.WriteLine("Вот, что получилось:");
MinCoordinates(firstmatrix);
PrintMatrix(DeleteMinCross(firstmatrix));
Console.Write("Нажмите на ввод, чтобы перейти к следующей задаче");
Console.ReadLine();
Console.Clear();


// Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно 
// на экран выводя индексы соответствующего элемента

void FillThreeDMatrix(int[,,] matrix)
{
    for (int i=0; i<matrix.GetLength(0); i++)
        for(int j=0; j<matrix.GetLength(1); j++)
            for(int k=0; k<matrix.GetLength(2); k++)
                matrix[i,j,k] = new Random().Next(10,100);         
}
void PrintThreeDMatrix(int[,,] matrix)
{
    for (int i=0; i<matrix.GetLength(0); i++)
        for(int j=0; j<matrix.GetLength(1); j++)
            for(int k=0; k<matrix.GetLength(2); k++)
                Console.WriteLine($"Элемент [{i},{j},{k}] -> {matrix[i,j,k]}");
}

Console.WriteLine("Задание №3. Сформировать трехмерный массив не повторяющимися двузначными\nчислами показать его построчно на экран выводя индексы соответствующего элемента");
Console.WriteLine("-------------------------------------------------------------------------");
Console.WriteLine("Нажмите ввод, чтобы увидеть элементы 3D-матрицы");
Console.ReadLine();
int[,,] threedeematrix = new int[3,3,3];
FillThreeDMatrix(threedeematrix);
PrintThreeDMatrix(threedeematrix);
Console.Write("Нажмите на ввод, чтобы перейти к следующей задаче");
Console.ReadLine();
Console.Clear();

// Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника

Console.WriteLine("Задание №3. Показать треугольник Паскаля\n*Сделать вывод в виде равнобедренного треугольник");
Console.WriteLine("--------------------------------------------");

double Factorial(int n)
    {
        double i, x = 1;
        for (i = 1; i <= n; i++)
        {
            x *= i;
        }
        return x;

    }
void Pascal(int n) // Чтобы треугольник был равнобедренным после 5ой строчки надо ещё подшаманить с отступами...
{
    for (int i = 0; i < n; i++)
    {
        for(int k = 0; k<(n-i); k++)
            Console.Write("  "); 
        for(int j = 0; j<=i; j++)
        {
            Console.Write(Factorial(i) / (Factorial(j) * Factorial(i - j)));
            Console.Write("   ");    
        }
        Console.WriteLine();
        Console.ReadLine();
    }
}

Console.WriteLine("Введите количество строк треугольника Паскаля:");
int n = int.Parse(Console.ReadLine()?? "0");
Pascal(n);