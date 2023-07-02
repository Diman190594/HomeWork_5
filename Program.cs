//Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных позициях.
/*
Console.WriteLine("Enter array");
int size = Convert.ToInt32(Console.ReadLine());
int [] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Your array: ");
PrintArray(numbers);
int count = 0;

for (int z = 0; z < numbers.Length; z++)
    if (numbers[z] % 2 == 0)
count++;

Console.WriteLine($"Total {numbers.Length} numbers, {count} of which are even");

void FillArrayRandomNumbers(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100, 1000);
    }
}
void PrintArray(int[] numbers)
{
    Console.WriteLine("[");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");   
    }
    Console.Write("]");
    Console.WriteLine();
}
*/

//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

/*
Console.WriteLine("Enter the size of the array");
int size = Convert .ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Your array: ");
PrintArray(numbers);
int sum = 0;

for (int z = 0; z < numbers.Length; z += 2)
    sum = sum + numbers[z];
    
    Console.WriteLine($"Total {numbers.Length} numbers sum of elements in odd positions = {sum}");

void FillArrayRandomNumbers(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(1, 10);
    }
}    

void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
} 
*/

