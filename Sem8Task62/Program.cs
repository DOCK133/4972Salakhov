// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

//  Функция заполнения массива по спирали начиная с 1
void FillArraySpiral(int[,] arr, int n)
{
    int i = 0, j = 0;
    int value = 1;
    for (int e = 0; e < n * n; e++)
    {
        int k = 0;
        do { arr[i, j++] = value++; } while (++k < n - 1);
        for (k = 0; k < n - 1; k++) arr[i++, j] = value++;
        for (k = 0; k < n - 1; k++) arr[i, j--] = value++;
        for (k = 0; k < n - 1; k++) arr[i--, j] = value++;
        ++i; ++j;
        n = n < 2 ? 0 : n - 2;
    }
}

//  Функция вывода двумерного массива в терминал
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] < 10)
            {
                Console.Write("0" + arr[i, j]);
                Console.Write(" ");
            }
            else Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}


int len = 4;
int[,] table = new int[len, len];
FillArraySpiral(table, len);
PrintArray(table);

// //Антон

// // Создаем спиральный массив
// int[,] GenerateSpiralArray(int n)
// {
//     int[,] spiral = new int[n, n];
//     int num = 1;
//     int rowStart = 0;
//     int rowEnd = n - 1;
//     int colStart = 0;
//     int colEnd = n - 1;

//     while (num <= n * n)
//     {
//         for (int i = colStart; i <= colEnd; i++)
//         {
//             spiral[rowStart, i] = num++;
//         }
//         rowStart++;

//         for (int i = rowStart; i <= rowEnd; i++)
//         {
//             spiral[i, colEnd] = num++;
//         }
//         colEnd--;

//         for (int i = colEnd; i >= colStart; i--)
//         {
//             spiral[rowEnd, i] = num++;
//         }
//         rowEnd--;

//         for (int i = rowEnd; i >= rowStart; i--)
//         {
//             spiral[i, colStart] = num++;
//         }
//         colStart++;
//     }

//     return spiral;
// }

// // Рекурсивный метод
// int[,] FillSpiral(int[,] matrix, int startNumber = 1, int count = 1)
// {
//     for (int j = -1 + count; j < matrix.GetLength(1) + 1 - count; j++)
//     {
//         matrix[-1 + count, j] = startNumber++;
//     }
//     for (int i = count; i < matrix.GetLength(0) + 1 - count; i++)
//     {
//         matrix[i, matrix.GetLength(1) - count] = startNumber++;
//     }
//     for (int j = matrix.GetLength(1) - 1 - count; j > -1 + count; j--)
//     {
//         matrix[matrix.GetLength(0) - count, j] = startNumber++;
//     }
//     for (int i = matrix.GetLength(0) - count; i > -1 + count; i--)
//     {
//         matrix[i, -1 + count] = startNumber++;
//     }
//     if (startNumber <= matrix.GetLength(0) * matrix.GetLength(1))
//     {
//         FillSpiral(matrix, startNumber, ++count);
//     }
//     return matrix;
// }

// int[,] array0 = FillSpiral(new int[m, n]);
// Output2DArray(array0, "Массив: ");