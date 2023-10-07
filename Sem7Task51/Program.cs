// Задача №51
// Задайте двумерный массив. Найдите сумму элементов,
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

// Вывод сообщения и запись введённых данных
int ReadData(string mes)
{
    Console.Write(mes);
    string value = Console.ReadLine() ?? ",";
    int num = Convert.ToInt32(value);

    return num;
}

// Метод заполнения двумерного массива
int[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
{
    System.Random rnd = new System.Random();
    int[,] array2D = new int[countRow, countColumn];

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = rnd.Next(downBorder, topBorder);
        }
    }

    return array2D;
}

// Выводит элементы массива в консоль
void Print2DArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

// int MainDiagSum(int[,] matrix)
// {
//     int res = 0;
//     int min = matrix.GetLength(0);
//     if (min > matrix.GetLength(1))
//         min = matrix.GetLength(1);
//     for (int i = 0; i < min; i++)
//         ;
//     {
//         res = res + matrix[i, i];
//     }
//     return res;
// }

int MainDiagSum(int[,] matrix)
{
    int n = matrix.GetLength(0) < matrix.GetLength(1)? matrix.GetLength(0): matrix.GetLength(1);
    int res = 0;
    for (int i = 0; i < n; i++)
    {
        res+=matrix[i,i];
    }
    return res;
}

int row = ReadData("введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");
int[,] arr2D = Fill2DArray(row, column, 10, 1);
Print2DArray(arr2D);
Console.WriteLine($"Сумма главной диаганали {MainDiagSum(arr2D)}");
