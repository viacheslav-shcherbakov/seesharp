// блок-схема
// input_array[]
// output_array []
// input str
// add str to array
// for items in input_array chose item where item.length <= 3 & add to output_array
// print output_array

Console.Clear();
Console.Write("Enter the number of elements to test: ");
int elements_number = int.Parse(Console.ReadLine() ?? "");
string [] input_array = new string [elements_number];
string [] output_array = new string [elements_number];

for(int i=0; i<input_array.Length; i++)
{
    Console.Write($"Enter a line #{i+1}: ");
    string input = Console.ReadLine() ?? "";
    input_array[i] = input;  
}
Console.Write("Here are the results (strings less then or equal to 3 characters long) ");
for(int i=0; i<input_array.Length; i++)
{
    if(input_array[i].Length <= 3)
    {        
        output_array[i] = input_array[i];
        Console.Write(output_array[i] + ", ");
    }
}