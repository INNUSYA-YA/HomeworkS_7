// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
int m = InputInt("ВВедите количество строк ");
int n = InputInt("ВВедите количество столбцов ");
double[,] numbers = new double[m, n];
FillArray(numbers);
PrintArray(numbers);
void FillArray(double[,] array)
{
    for (int i=0; i<array.GetLength(0);i++)
    {
        for (int j=0; j<array.GetLength(1);j++)
        {
        array[i,j] = new Random().Next(0,100)/10.0;
        }
    }
}
int InputInt (string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
void PrintArray(double[,] array)
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