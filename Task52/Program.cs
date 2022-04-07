/*
Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

//создает массив из случайных целых чисел в диапазоне от [0; limit)
int[,] GenerateMatrix(int hight, int weight, int limit)
{
    int[,] generatedArray = new int[hight, weight];
    for (int i = 0; i < hight; i++)
    {
        for (int j = 0; j < weight; j++)
        {
            generatedArray[i, j] = new Random().Next(limit);
        }
    }
    return generatedArray;
}

//выводит массив в определенном формате
void PrintMatrix(int[,] arrayToPrint)
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

//находит среднее арифметическое элементов в каждом столбце
void GetAverageInColumn(int[,] arrayToGet)
{
    for (int i = 0; i < arrayToGet.GetLength(1); i++)
    {
        double sum = 0,
               average = 0;
        for (int j = 0; j < arrayToGet.GetLength(0); j++)
        {
            sum += arrayToGet[j, i];
        }
        average = sum / arrayToGet.GetLength(0);
        Console.Write($"{Math.Round((average), 1)}\t");
        sum = 0;
    }
}

int hight = new Random().Next(2, 5),
    weight = new Random().Next(2, 5);
int[,] generatedArray = GenerateMatrix(hight, weight, 10);
PrintMatrix(generatedArray);
Console.WriteLine("Среднее арифметическое каждого столбца: ");
GetAverageInColumn(generatedArray);
