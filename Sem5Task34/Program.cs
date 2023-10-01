// №34 Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
// [845, 222, 367, 123] -> 1
// (со звездочкой) Отсортировать массив методом пузырька

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

// Вызываем генерацию массива 
int[] arr = GenArr(12, 100, 999);
// Выводим изначальный массив
PrintArr(arr);
// Считаем количество чисел
int count = CountEvn(arr);
// Печатаем результат
PrintResult("количество чётных чисел в массиве " + count);