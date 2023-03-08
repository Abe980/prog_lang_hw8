// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Задача 54");
Console.WriteLine();

int[,] matr = GetMatrix(3, 4, -9, 10);
PrintMatrix(matr);
Console.WriteLine();
PrintMatrix(SortReverseRow(matr));


/// <summary>
/// Упорядочивает по убыванию элементы каждой строки двумерного массива
/// </summary>
/// <param name="arr">Двухмерный массив целых чисел</param>
/// <returns>
/// Двухмерный массив целых чисел с упорядочеными по убыванию элементами каждой строки
/// </returns>
int[,] SortReverseRow(int[,] arr)
{
    int [,] sortArr = new int[arr.GetLength(0), arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int[] tempArr = new int[arr.GetLength(1)];
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            tempArr[j] = arr[i, j];
        }
        Array.Sort(tempArr);
        Array.Reverse(tempArr);
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sortArr[i, j] = tempArr[j];
        }
    }
    return sortArr;
}


/// <summary>
/// Заполняет двухмерный массив числами от min до max
/// </summary>
/// <param name="rows">Количество строк</param>
/// <param name="cols">Количество столбцов</param>
/// <param name="min">Минимальное число для рандома</param>
/// <param name="max">Максимальное число для рандома</param>
/// <returns>Заполненный двухмерный массив целых чисел</returns>
int[,] GetMatrix(int rows, int cols, int min, int max)
{
    int[,] matrix = new int[rows, cols];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}


/// <summary>
/// Печатает двухмерную матрицу целых чисел
/// </summary>
/// <param name="inputMatrix">Думерный массив целых чисел</param>
void PrintMatrix(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            Console.Write(inputMatrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}




// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Задача 56");
Console.WriteLine();

int[,] matrix = GetMatrix(3, 4, 0, 10);
PrintMatrix(matrix);
MinSumRow(matrix);


/// <summary>
/// Находит строку с наименьшей суммой элементов в двумерном массиве
/// печатает индекс строки в консоль
/// </summary>
/// <param name="arr">Думерный массив целых чисел</param>
void MinSumRow(int[,] arr)
{
    int minSum = Int32.MaxValue;
    int minRow = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[i, j];
        }
        if (sum < minSum)
        {
            minSum = sum;
            minRow = i;
        }
    }
    Console.WriteLine($"Индекс строки с минимальной суммой элементов: {minRow}");
}



// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Задача 58");
Console.WriteLine();

int[,] arr1 = {
    {2, 4},
    {3, 2},
};

int[,] arr2 = {
    {3, 4},
    {3, 3},
};


ProductMatrices(arr1, arr2);


/// <summary>
/// Умножает две двухмерных матрицы целых чисел, печатает результат в консоль
/// </summary>
/// <param name="arr1">Первый множитель</param>
/// <param name="arr2">Второй множитель</param>
void ProductMatrices(int[,] arr1, int[,] arr2)
{
    if (arr1.GetLength(1) != arr2.GetLength(0))
    {
        Console.WriteLine("Матрицы не согласованы, произведение не возможно");
    }
    else
    {
        int[,] result = new int[arr1.GetLength(0), arr2.GetLength(1)];
        for (int i = 0; i < result.GetLength(0); i++)
        {
            for (int j = 0; j < result.GetLength(1); j++)
            {
                result[i, j] = 0;
                for (int k = 0; k < arr2.GetLength(1); k++)
                result[i, j] += arr1[i, k] * arr2[k, j];
            }
        }
        PrintMatrix(result);
    }
}



// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Задача 60");
Console.WriteLine();

GetPrint3DMatrix(2, 2, 2);


/// <summary>
/// Формирует трехмерный массив и печатает его по строкам с расположением координат
/// строго как в примере...
/// </summary>
/// <param name="rows">Количество строк</param>
/// <param name="cols">Количество столбцов</param>
/// <param name="deep">Глубина</param>
void GetPrint3DMatrix(int rows, int cols, int deep)
{
    int[,,] arr = new int[rows, cols, deep];
    for (int k = 0; k < deep; k++)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                // На семинаре Вы говорили, что можно просто рандом сделать...
                Console.Write($"{new Random().Next(10, 100)} ({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}