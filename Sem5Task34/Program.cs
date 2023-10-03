// №34 Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
// [845, 222, 367, 123] -> 1
// (со звездочкой) Отсортировать массив методом пузырька

// Генерируем массив случайными цифрами
int[] GenArr(int length, int lowBorder, int highBorder)
{
    int[] arr = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
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

// Печатаем результат
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

// Считаем чётные числа
int CountEvn(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;

}

// // Пузырьковая сортировка
// void BubbleSort(int[] arr)
// {
//     int n = arr.Length;
//     for (int i = 0; i < n - 1; i++)
//         for (int j = 0; j < n - i - 1; j++)
//             if (arr[j] > arr[j + 1])
//             {
//                 // Меняем местами элемены
//                 int temp = arr[j];
//                 arr[j] = arr[j + 1];
//                 arr[j + 1] = temp;
//             }
// }


// Вызываем генерацию массива 
int[] arr = GenArr(12, 100, 999);
// Выводим изначальный массив
PrintArr("Исходный массив: " + arr);
// Считаем количество чисел
int count = CountEvn(arr);
// Печатаем результат
PrintResult("количество чётных чисел в массиве " + count);
// //Сортируем массив пузырьком
// BubbleSort(arr);
// PrintArr("отсортированный массив: " + arr);