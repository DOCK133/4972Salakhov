// Задача 67
// Программа примает на вход число N и возвращает сумму цифр в числе

// Вывод сообщения и запись введённых данных
int ReadData(string message)
{
    Console.Write(message);
    string value = Console.ReadLine() ?? ",";
    int number = Convert.ToInt32(value);

    return number;
}

int SumDigitRec(int num)
{
    if (num == 0)
    {
        return 0;
    }
    else
    {
        return num % 10 + SumDigitRec(num / 10);
    }
}

int number=ReadData("Введите число: ");
System.Console.WriteLine("Сумма всех цифр в числе " +number+ " равна " +SumDigitRec(number));