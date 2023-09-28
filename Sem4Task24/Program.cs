// Задача 24:
// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 --> 28
// 4 --> 10
// 8 --> 36

// Вводим данные
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

int SimpieSum(int numA)
{
    int sumOfNumber = 0;
    for (int i = 1; i <= numA; i++)
    {
        //sumOfNumber = sumOfNumber + i;
        sumOfNumber += i;
    }
    return sumOfNumber;
}

int GausseSum(int numA)
{
    int sumOfNumber = 0;
    sumOfNumber = numA * (numA + 1) / 2;
    return sumOfNumber;
}

int numberA = ReadData("Введите число А: ");

DateTime d1 = DateTime.Now;
int res1 = SimpieSum(numberA);
Console.WriteLine(DateTime.Now - d1);

DateTime d2 = DateTime.Now;
int res2 = GausseSum(numberA);
Console.WriteLine(DateTime.Now - d2);

PrintResult("Сумма чисел от 1 до " + numberA + " (простой)Равна " + res1);
PrintResult("Сумма чисел от 1 до " + numberA + " (Гаусса)Равна " + res2);

// Печатаем результат
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}
