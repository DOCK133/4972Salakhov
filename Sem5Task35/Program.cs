// Задача 35:
// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
// значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2]   --> 1
// [1, 2, 3, 6, 2]      --> 0
// [10, 11, 12, 13, 14] --> 5

// Генерируем массив случайными цифрами
int[] GenArr(int num, int lowBorder, int highBorder)
{
    int[] arr = new int[num];
    Random rnd = new Random();
    for (int i = 0; i < num; i++)
    {
        arr[i] = new Random().Next(lowBorder, highBorder + 1);
    }
    return arr;
}

// Печатаем массив
void PrintArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

// Считаем количество элементов
int CountElement(int[] arr, int x, int y)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if ((arr[i] >= x) && (arr[i] <= y))
        {
            count++;
        }
    }
    return count;
}

// Печатаем результат
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

// Вызываем генерацию массива 
int[] arr = GenArr(123, 0, 130);
// Выводим изначальный массив
PrintArr(arr);
// Устанавливаем границы
int x = 10;
int y = 99;
// Считаем количество элементов
int count = CountElement(arr, x, y);
// Печатаем результат
PrintResult(+count + " элементов в заданном массиве");