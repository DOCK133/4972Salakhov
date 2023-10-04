// Задача 44:
// Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 --> 0 1 1 2 3
// Если N = 3 --> 0 1 1
// Если N = 7 --> 0 1 1 2 3 5 8

// Вывод сообщения и запись введённых данных
int ReadData(string mes)
{
    Console.Write(mes);
    string value = Console.ReadLine() ?? ",";
    int num = Convert.ToInt32(value);

    return num;
}

void PrintFibNum(int num)
{
    int buf = 0;
    int first = 0;
    int second = 1;
    Console.Write(first + " " + second);
    for (int i = 2; i < num; i++)
    {
        Console.Write(" " + (first + second));
        buf = first + second;
        first = second;
        second = buf;
    }
}

int num = ReadData("введите число ");
PrintFibNum(num);