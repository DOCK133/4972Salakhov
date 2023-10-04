// Задача 42:
// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45  --> 101101
// 3   --> 11
// 2   --> 10

// Вывод сообщения и запись введённых данных
int ReadData(string mes)
{
    Console.Write(mes);
    string value = Console.ReadLine() ?? ",";
    int num = Convert.ToInt32(value);

    return num;
}

// Преобразовываем десятичное число в двоичное (простой нерекурентный способ)
string DecToBin(int num)
{
    string line = "";
    while (num > 0)
    {
        line = num % 2 + line;
        num = num / 2;
    }
    return line;
}

// Переводит число в двоичное (рекурентный способ)
string DecToBinRec(int number)
{
    return number == 0 ? "" : DecToBin(number / 2) + Convert.ToString(number % 2);
}

int num = ReadData("введите число ");
Console.WriteLine("Двоичное представление числа(Simpl): " + DecToBin(num));
Console.WriteLine("Двоичное представление числа(recurent): " + DecToBinRec(num));
