// Задача 31:
// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [ -9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве [3, 9, -8, 1, 0, -7, 2, -1, 8, -3, -1, 6] сумма положительных чисел равна 29, 
// сумма отрицательных равна 20.

// Выполняем одномерный массив
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

(int, int) NegativPositivSum(int[] arr)
{
    int posSum = 0;
    int negSum = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            posSum = posSum + arr[i];
        }
        else
        {
            negSum += arr[i];
        }
    }
    return (posSum, negSum);
}

int[] arr = GenArr(12, -9, 9);
PrintArr(arr);
(int pos, int neg) sum = NegativPositivSum(arr);

Console.WriteLine("Сумма > 0: " + sum.pos + " Сумма < 0: " + sum.neg);