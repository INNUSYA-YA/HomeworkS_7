// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет. Во вводе первая цифра - номер строки, вторая - столбца. Цифры не больше 9.
int m = InputInt("ВВедите количество строк ");
int n = InputInt("ВВедите количество столбцов ");
int[,] numbers = new int[m, n];
FillArray(numbers);
PrintArray(numbers);
int num = InputInt("ВВедите позицию элемента в двумерном массиве ");
for (int i=0; i<numbers.GetLength(0);i++)
{   int numOne = num/10;
    int numTwo = num%10;

for (int j=0; j<numbers.GetLength(1);j++)
{ 
    if(numOne==i&&numTwo==j)
    {
         Console.WriteLine($"Значение элемента массива - {numbers[i,j]}");
    }     
            if (numOne>numbers.GetLength(0))
    {
        Console.WriteLine($"такого элемента в массиве нет.");
        return;
    }
}
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