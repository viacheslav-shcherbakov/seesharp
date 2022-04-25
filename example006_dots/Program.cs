//The program about dots
Console.Clear();
Console.WriteLine("This is a graphic console to add points");
Console.Write("Enter the number of dots from 1 to 30: -> ");
int x = int.Parse(Console.ReadLine() ?? "");
int count = 0;
int ptA = 0, ptB = 0;
if (x > 0 && x <= 30)
{
    while(count <= x)
    {
        Console.SetCursorPosition(ptA, ptB);
        Console.WriteLine("+");
        ptA ++;
        ptB ++;
        count ++;
    }
}
else 
{
    Console.WriteLine("Too big number");
}
