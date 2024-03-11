// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("Modyfikacja 1");
Console.WriteLine("Modyfikacja 2");
Console.WriteLine("Modyfikacja 3");

for (int i = 0; i < 5; i++) 
{
    Console.WriteLine(i);
}

static double CalculateAverage(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        sum += array[i];
    }
    return (double)sum / array.Length;
}

int[] array = {1, 2, 3, 4, 5};
Console.WriteLine(CalculateAverage(array));