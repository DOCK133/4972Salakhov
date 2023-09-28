// Задача 30:
// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// Вводим данные (определяем длинну массива)
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}
// Генерируем массив случайными цифрами
int[] GenArr(int gen)
{
    int[] arr = new int[gen];
    Random rnd = new Random();
    for (int i = 0; i < gen; i++)
    {
        arr[i] = rnd.Next(0, 2);
    }
    return arr;
}

// Печатаем массив
void PrintArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

int gen = ReadData("Введите размер массива: ");
//int[] arr = new int [gen];
int[] arr = GenArr(gen);
PrintArr(arr);