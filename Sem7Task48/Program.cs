// Задача 48:
// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: A ₘₙ = m+n.
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

// Вывод сообщения и запись введённых данных
int ReadData(string mes)
{
    Console.Write(mes);
    string value = Console.ReadLine() ?? ",";
    int num = Convert.ToInt32(value);

    return num;
}

// Метод заполнения двумерного массива
void Fill2DSumm(int[,] arr, int m, int n)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = i + j;
        }
    }
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

int m = ReadData("Введите m: ");
int n = ReadData("Введите n: ");

int[,] arr = new int[m, n];
Fill2DSumm(arr, m, n);
Print2DArray(arr);
