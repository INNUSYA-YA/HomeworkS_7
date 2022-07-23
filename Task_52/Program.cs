// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int m = InputInt("ВВедите количество строк ");
int n = InputInt("ВВедите количество столбцов ");
int[,] numbers = new int[m, n];
FillArray(numbers);
PrintArray(numbers);

for (int j=0; j<numbers.GetLength(1);j++)
{  
    double sum = 0;
for (int i=0; i<numbers.GetLength(0);i++)
{
   sum += numbers[i,j];
}
Console.Write($"{ sum / numbers.GetLength(0)} ");
}

void FillArray(int[,] array)
{
    for (int i=0; i<array.GetLength(0);i++)
    {
        for (int j=0; j<array.GetLength(1);j++)
        {
        array[i,j] = new Random().Next(0,10);
        }
    }
}
int InputInt (string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
void PrintArray(int[,] array)
{
 for (int i=0; i<array.GetLength(0);i++)
{
     for (int j=0; j<array.GetLength(1);j++)
    {
    Console.Write(array[i,j]+ " ");
    }
    Console.WriteLine();
}
}