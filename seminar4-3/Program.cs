// Посчитать сумму значений одномерного массива на нечетных позициях
Console.Clear();
int [] arr = { 1, 2, 3, 4, 5, 7, 9};
int sum = 0;
for(int v = 0; v <= arr.Length; v = v+2)
{       
    sum = sum + arr[v];
}
Console.WriteLine(sum);