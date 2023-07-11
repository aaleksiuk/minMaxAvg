using Microsoft.Win32.SafeHandles;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.ExceptionServices;


var numbers = InitializeTable();

for (var i = 0; i < numbers.Length; i++)
{
    numbers[i] = GetValue(i);
}

var minNumber = GetMinValue();
var maxNumber = GetMaxValue();
var average = GetAverageValue();

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
        Console.WriteLine(e.Message);
        return GetValue(i);
    }
}
decimal GetAverageValue()
{
    decimal sum = 0;
    for (var i = 0; i < numbers.Length; i++)
    {

        sum += numbers[i];
    }

    return sum / numbers.Length;
}

int GetMinValue()
{
    int min = numbers[0];
    for (int i = 1; i < numbers.Length; i++)
    {

        if (min > numbers[i])
        {
            min = numbers[i];
        }
    }
    return min;
}

int GetMaxValue()
{
    int max= numbers[0];
    for (int i = 1; i < numbers.Length; i++)
    {
        if (numbers[i] > max)
        {
            max = numbers[i];
        }
    }
    return max;
}

