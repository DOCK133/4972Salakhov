// Задача 49:
// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.
// Например, изначально массив     Новый массив будет выглядеть
// выглядел вот так:               вот так:
// 1 4 7 2                         1   4  7  2
// 5 9 2 3                         5 "81" 2 "9"
// 8 4 2 4                         8   4  2  4

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
            array2D[i,j] = rnd.Next(downBorder,topBorder);
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
            Console.Write(matrix[i,j]+" ");
        }
        Console.WriteLine();
    }
}

// Проверка на четность числа и замена на их квадрат
void Update2DArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++) // либо i=i+2 - и проверка на четность не нужна
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // либо j=j+2 - и проверка на четность не нужна
        {
            // проверка на четность
            if(i%2 ==  0 && j%2 == 0) 
            {
                matrix[i,j] = matrix[i,j]*matrix[i,j]; //matrix[i,j] *= matrix[i,j];
            }
        }
    }
}

int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");
int[,] arr2D = Fill2DArray(row,column,10,1);
Print2DArray(arr2D);
Update2DArray(arr2D);
Print2DArray(arr2D);