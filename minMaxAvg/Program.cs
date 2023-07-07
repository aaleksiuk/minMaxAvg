using Microsoft.Win32.SafeHandles;
using System.Runtime.ExceptionServices;


int[] numbers = InitializeTable();

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = GetValue(i);
}

int minNumber = numbers.Min();
int maxNumber = numbers.Max();
double average = numbers.Average();

Console.WriteLine($"Maximum number is: {maxNumber}\nMinimum number is: {minNumber}\nAverage number is: {average}");

int[] InitializeTable()
{
    int lenght;
    try
    {
        Console.WriteLine("Quantity of numbers from user:");
        lenght = Convert.ToInt32(Console.ReadLine());
        if (lenght >= 1)
        {
            return new int[lenght];
        }
        else
        {
            Console.WriteLine("Quantity of numbers from user MUST be greater than 0");
            return InitializeTable();
        }
    }

    catch (Exception e)
    {
        Console.WriteLine(e.Message);
        return InitializeTable();
    }

}
int GetValue(int i)
{
    try
    {
        Console.WriteLine($"Get {i} element");
        return Convert.ToInt32(Console.ReadLine());
    }

    catch (Exception e)
    {
        Console.WriteLine(e);
        return GetValue(i);
    }
}