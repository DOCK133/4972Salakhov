// №38 Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3, 7, 22, 2, 78]      -> 76
// [2, 0, 4, 9, 7, 2, 78] -> 77,6
// (со звездочкой) Отсортируйте массив методом вставки и методом подсчета, а затем найдите разницу 
// между первым и последним элементом. Для задачи со звездочкой использовать заполнение массива целыми числами.


Console.Write("Введите количество элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());
double[] ranArr = new double[a];

void GenArr(int a)
{
    Random rand = new Random();
    for (int i = 0; i < a; i++)
    {
        ranArr[i] = rand.NextDouble();
        Console.Write($"{ranArr[i]:F2} ");
    }

}

double SumNegPos(double[] ranArr)
{
    double min = ranArr[0];
    double max = ranArr[0];
    int i = 1;
    while (i < ranArr.Length)
    {
        if (max < ranArr[i])
            max = ranArr[i];
        if (min > ranArr[i])
            min = ranArr[i];
        i = i + 1;
    }
    return max - min;
}

GenArr(a);
Console.Write($"\nРазница между максимальным и минимальным элементов массива: { SumNegPos(ranArr):F2}");