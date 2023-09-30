// Задача 37:
// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
// второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] --> 5 8 3
// [6 7 3 6]   --> 12 10

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
    Console.Write("[ ");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + " ]");
}

// Конвертируем массив
int[] ConvertArr(int[] arr)
{
    int[] outArr = new int[arr.Length / 2];
    for (int i = 0; i < arr.Length / 2; i++)
    {
        outArr[i] = arr[i] * arr[arr.Length - 1 - i];
    }

    return outArr;
}

// Вызываем генерацию массива 
int[] arr = GenArr(8, 0, 20);
// Выводим изначальный массив
PrintArr(arr);
// Выводим результат массива
PrintArr(ConvertArr(arr));