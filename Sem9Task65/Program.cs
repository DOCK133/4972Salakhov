// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
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
string RecMN(int m, int n)
{
    return n >= m ? $"{m} " + RecMN(m + 1, n) : "";
}

int m = ReadData("Введите m: ");
int n = ReadData("Введите n: ");

//                  тернарная операция
Console.WriteLine((m>n)?RecMN(n, m):RecMN(m,n));