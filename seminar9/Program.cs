// Семинар 9 Найти сумму цифр числа

Console.Clear();
int SumOfNumbers(int n) => n==0 ? n : n%10 + SumOfNumbers(n/10);       
//Console.WriteLine(SumOfNumbers(n));




//Написать программу возведения числа А в целую стень B

double Amount(int a, int b) => b==1 ? a : a*Amount(a,b-1);

Console.Write("Введите число, которое надо возвести в степень: ");
int a = int.Parse(Console.ReadLine()?? "0");
Console.Write("Введите степень: ");
int b = int.Parse(Console.ReadLine()?? "0");
Console.WriteLine(Amount(a,b));

// Написать программу показывающие первые N чисел, 
// для которых каждое следующее равно сумме двух предыдущих. 
// Первые два элемента последовательности задаются пользователем

int Fibbonachi(int c, int n)
{
    if(n==0) return c;    
    return c + Fibbonachi(c,n-1);
}
int l = 10;
int c = a+b;
Console.Write(Fibbonachi(c,l));
