/*
Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

//создает массив из случайных вещественных чисел в диапазоне от [-limit; limit)
double[,] GenerateMatrix(int hight, int weight, int limit)
{
    double[,] generatedArray = new double[hight, weight];
    for (int i = 0; i < hight; i++)
    {
        for (int j = 0; j < weight; j++)
        {
            generatedArray[i, j] = new Random().Next(limit * -1, limit)
                                 + Math.Round(new Random().NextDouble(), 1);
        }
    }
    return generatedArray;
}

//выводит массив в определенном формате
void PrintMatrix(double[,] arrayToPrint)
{
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write($"{arrayToPrint[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int hight = 3,
    weight = 4;
double[,] generatedArray = GenerateMatrix(hight, weight, 10);
PrintMatrix(generatedArray);