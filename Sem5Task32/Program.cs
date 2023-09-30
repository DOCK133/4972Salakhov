// Задача 32:
// Напишите программу замена элементов массива: положительные элементы 
// замените на соответствующие отрицательные, и наоборот.
// [ -4, -8, 8, 2] --> [ 4, 8, -8, -2]

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

void InversArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = arr[i] * -1;
    }
}

int[] arr = GenArr(12, -9, 9);
PrintArr(arr);
InversArr(arr);
PrintArr(arr);