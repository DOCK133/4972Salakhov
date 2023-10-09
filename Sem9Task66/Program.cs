// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Вывод сообщения и запись введённых данных
int ReadData(string message)
{
    Console.Write(message);
    string value = Console.ReadLine()??",";
    int number = Convert.ToInt32(value);

    return number;
}

// Формирование строки с числами
void SumFromMN(int m, int n)
{
    Console.Write("Сумма элементов =" +SumMN(m - 1, n));
}

// Метод "сумма чисел от M до N"
int SumMN(int m, int n)
{
    int res = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        res = m + SumMN(m, n);
        return res;
    }
}

// Тело программы
int m = ReadData("Введите M: ");
int n = ReadData("Введите N: ");
SumFromMN(m, n);