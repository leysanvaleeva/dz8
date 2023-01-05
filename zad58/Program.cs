// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Введите число строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] firstArray= new int[rows, columns];
FillArray(firstArray);
PrintArray(firstArray);
Console.WriteLine();

int[,] secondArray = new int[rows, columns];
FillArray(secondArray);
PrintArray(secondArray);
Console.WriteLine();

int[,] productArray = new int[rows, columns];
Product(firstArray, secondArray, productArray);
PrintArray(productArray);

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 5);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],3}\t");
        Console.WriteLine();
    }
}

void Product(int[,] firstArray, int[,] secondArray, int[,] resultArray)
{
    for (int i = 0; i < resultArray.GetLength(0); i++)
    {
        for (int j = 0; j < resultArray.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstArray.GetLength(1); k++)
            {
                sum += firstArray[i, k] * secondArray[k, j];
            }
            resultArray[i, j] = sum;
        }
    }
}

