/*
______________________________________________________________________________________________
Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
пример индексов этого массива:
0 1 2 3
4 5 6 7
8 9 10 11
12 13 14 15
______________________________________________________________________________________________
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

//выводит значение элемента указанной позиции в массиве, если есть
void PrintMatrixElement(int[,] matrixElementToPrint, int hight, int weight)
{
    if (hight < matrixElementToPrint.GetLength(0) && weight < matrixElementToPrint.GetLength(1))
    {
        Console.WriteLine($"Элемент массива на позиции [{hight}, {weight}] равен: {matrixElementToPrint[hight, weight]}");
    }
    else Console.WriteLine($"Элемента на позиции [{hight}, {weight}] нет в массиве");
}

int hight = new Random().Next(2, 10),
    weight = new Random().Next(2, 10);
int[,] generatedArray = GenerateMatrix(hight, weight, 100);
PrintMatrix(generatedArray);

Console.Write("Введите номер строки: ");
int lineNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер графы: ");
int columnsNumber = Convert.ToInt32(Console.ReadLine());
PrintMatrixElement(generatedArray, lineNumber, columnsNumber);
