// Задача 39:
// Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый на
// последнем и т.д.)
// [1 2 3 4 5] --> [5 4 3 2 1]
// [6 7 3 6]   --> [6 3 7 6]

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

// [1 2 3 4 5]
// [5 4 3 2 1]

// Разворот массива с созданием нового массива и перестановкой цифр (переворот)
int[] SwapNewArray(int[] arr)
{
    int[] outArr = new int[arr.Length];

    for (int i = 0; i < arr.Length; i++)
    {
        outArr[arr.Length - 1 - i] = arr[i];
    }
    return outArr;
}

// Способ переворота самого массива (создание пустой ячейки, и с её помощью переставляем цифры)
void SwapArray(int[] arr)
{
    int buferElement = 0;
    // Не переставляем цифру в середине (проходим только половину массива)
    for (int i = 0; i < arr.Length / 2; i++)
    {
        // Синтаксический сахар
        // (arr[arr.Length - 1 - i], arr[i]) = (arr[i], arr[arr.Length - 1 - i]);

        buferElement = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = arr[i];
        arr[i] = buferElement;
    }
}

int[] arr = GenArr(15, 1, 100);
PrintArr(arr);
int[] swapArr = SwapNewArray(arr);
Console.WriteLine("Исходный массив");
PrintArr(arr);
Console.WriteLine("Перевёрнутый массив");
PrintArr(swapArr);

SwapArray(arr);
Console.WriteLine("Перевёрнутый массив2");
PrintArr(arr);