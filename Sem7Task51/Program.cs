// // Задача №51
// // Задайте двумерный массив. Найдите сумму элементов,
// // находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

// // Вывод сообщения и запись введённых данных
// int ReadData(string mes)
// {
//     Console.Write(mes);
//     string value = Console.ReadLine() ?? ",";
//     int num = Convert.ToInt32(value);

//     return num;
// }

// // Метод заполнения двумерного массива
// int[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
// {
//     System.Random rnd = new System.Random();
//     int[,] array2D = new int[countRow, countColumn];

//     for (int i = 0; i < countRow; i++)
//     {
//         for (int j = 0; j < countColumn; j++)
//         {
//             array2D[i, j] = rnd.Next(downBorder, topBorder);
//         }
//     }

//     return array2D;
// }

// // Выводит элементы массива в консоль
// void Print2DArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// // int MainDiagSum(int[,] matrix)
// // {
// //     int res = 0;
// //     int min = matrix.GetLength(0);
// //     if (min > matrix.GetLength(1))
// //         min = matrix.GetLength(1);
// //     for (int i = 0; i < min; i++)
// //         ;
// //     {
// //         res = res + matrix[i, i];
// //     }
// //     return res;
// // }

// int MainDiagSum(int[,] matrix)
// {
//     int n = matrix.GetLength(0) < matrix.GetLength(1)? matrix.GetLength(0): matrix.GetLength(1);
//     int res = 0;
//     for (int i = 0; i < n; i++)
//     {
//         res+=matrix[i,i];
//     }
//     return res;
// }

// int row = ReadData("введите количество строк: ");
// int column = ReadData("Введите количество столбцов: ");
// int[,] arr2D = Fill2DArray(row, column, 10, 1);
// Print2DArray(arr2D);
// Console.WriteLine($"Сумма главной диаганали {MainDiagSum(arr2D)}");


// Вывод сообщения и запись введённых данных
int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine()??",";
    int number = Convert.ToInt32(value);

    return number;
}
// Заполняет массив случайными цифрами
void Random2DArray(int[,] array, int minElement, int maxElement)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(minElement, maxElement);
}
// Ищет элементы, у которых оба индекса чётные и меняет их
int MainDiagonalSum(int[,] array)
{
    int sum = 0;

    for (int i = 0; i < array.GetLength(0) && i < array.GetLength(1); i++)
        sum += array[i, i];

    return sum;
}
// Выводит элементы массива в консоль
void Output2DArray(int[,] array, string message)
{
    Console.WriteLine(message);

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("{");

        for (int j = 0; j < array.GetLength(1) - 1; j++)
            Console.Write(array[i, j] + ",\t ");

        Console.WriteLine(array[i, array.GetLength(1) - 1] + "}");
    }
}

int m = Prompt("Введите m: ");
int n = Prompt("Введите n: ");
int minElement = 0;
int maxElement = 10;

int[,] array = new int[m, n];
Random2DArray(array, minElement, maxElement);
Output2DArray(array, "Массив: ");

Console.WriteLine("Сумма эл-тов главной диагонали: " + MainDiagonalSum(array));