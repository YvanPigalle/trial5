
//Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.



/*

void RandomArray(int[] massive)
{
    for (int i = 0; i < massive.Length; i++)
    {
        massive [i] = new Random().Next(100,1000);
    }
}


void PrintArray(int[] array1)
{
    for (int i = 0; i < array1.Length; i++)
    {
        Console.Write (array1 [i] + " ");
    }
    Console.WriteLine();
}


Console.WriteLine("Insert massive's size: ");
int size = Convert.ToInt32(Console.ReadLine());
int [] array1 = new int [size];

RandomArray(array1);
PrintArray(array1);

int count = 0;

for (int i = 0; i < array1.Length; i++)
if (array1 [i] % 2 == 0)
count++;

Console.WriteLine($"There is {count} even numbers");

*/



//Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных позициях.



/*

void RandomArray(int[] massive)
{
    for (int i = 0; i < massive.Length; i++)
    {
        massive [i] = new Random().Next(-100,100);
    }
}


void PrintArray(int[] array1)
{
    for (int i = 0; i < array1.Length; i++)
    {
        Console.Write (array1 [i] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Insert massive's size: ");
int size = Convert.ToInt32(Console.ReadLine());
int [] numbers = new int [size];

RandomArray (numbers);
PrintArray(numbers);

int sum = 0;

for (int i = 1; i < numbers.Length; i += 2)
    sum += numbers [i];

    Console.WriteLine($"Sum of odd position numbers is = {sum}");

    */



    //Задайте массив вещественных чисел.
    //Найдите разницу между максимальным и минимальным элементов массива.




void RandomArray (double [] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
        {
            numbers [i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}

void PrintArray(double [] numbers)
{
    Console.Write(" | ");
    for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers [i] + " | ");
        }
    Console.WriteLine();
}

Console.WriteLine("Insert massive's size: ");
int size = Convert.ToInt32(Console.ReadLine());
double [] numbers = new double [size];

RandomArray (numbers);
PrintArray(numbers);

double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers [i] > max)
        {
            max = numbers [i];
        }
    if (numbers [i] < min)
        {
            min = numbers [i];
        }
}

Console.WriteLine($"Difference between maximum ({max}) and minimum({min}) is  = {max - min}");