// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Вывод сообщения и запись введённых данных
int ReadData(string message)
{
    Console.Write(message);
    string value = Console.ReadLine()??",";
    int number = Convert.ToInt32(value);

    return number;
}

// Метод заполнения массива рандомными числами от 1 до 9
void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

// Вывод элементы массива в консоль
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

int row = ReadData("Введите количество строк: ");
int columns = ReadData("Введите количество столбцов: ");
int[,] array = new int[row, columns];
int[,] secondArr = new int[row, columns];
int[,] resultArr = new int[row, columns];

FillArrayRandom(array);
Print2DArray(array);

Console.WriteLine();

FillArrayRandom(secondArr);
Print2DArray(secondArr);

Console.WriteLine();

if (array.GetLength(0) != secondArr.GetLength(1))
{
    Console.WriteLine(" Нельзя перемножить ");
    return;
}
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < secondArr.GetLength(1); j++)
    {
        resultArr[i, j] = 0;
        for (int k = 0; k < array.GetLength(1); k++)
        {
            resultArr[i, j] += array[i, k] * secondArr[k, j];
        }
    }
}

Print2DArray(resultArr);