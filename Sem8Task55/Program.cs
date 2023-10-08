// Задача 55:
// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.
// 3  4  5 -> 3  6  9
// 6  7  8 -> 4  7 10
// 9 10 11 -> 5  8 11

// Вывод сообщения и запись введённых данных
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Выводит элементы массива в консоль
void Print2DArray(int[,] matrix)
{
     for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j]+" ");
        }
        Console.WriteLine();
    }
}

// Метод заполнения двумерного массива
int[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
{
    System.Random rnd = new System.Random();
    int[,] arr2D = new int[countRow, countColumn];

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            arr2D[i, j] = rnd.Next(downBorder, topBorder);
        }
    }

    return arr2D;
}

// Проверка
bool TestArrot(int[,] arr)
{
    if (arr.GetLength(0) == arr.GetLength(1))
    {
        return true;
    }
    else
    {
        return false;
    }
}

// Метод поворота матрицы
void Rotate2DArray(int[,] arr)
{
    int buf = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 1 + i; j < arr.GetLength(1); j++)
        {
            buf = arr[i, j];
            arr[i, j] = arr[j, i];
            arr[j, i] = buf;
        }
    }
}

int n = ReadData("Кол-во строк: ");
int m = ReadData("Кол-во столбцов: ");
Console.WriteLine("Исходная матрица");
int[,] arr2D = Fill2DArray(n,m,10,1);
Print2DArray(arr2D);

Console.WriteLine("--------------------");

Rotate2DArray(arr2D);
Print2DArray(arr2D);