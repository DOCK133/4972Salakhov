// // Задача 26:
// // Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// // 456 --> 3
// // 78 --> 2
// // 89126 --> 5


////// Решение 1
// // Вводим данные
// int ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     int num = int.Parse(Console.ReadLine() ?? "0");
//     return num;
// }

// int NumDigits(int num)
// {
//     int count = 0;
//     while (num > 0)
//     {
//         count++; // count = count +1;
//         num = num / 10;
//     }
//     return count;
// }
// int num = ReadData("Введите число: ");

// int res = NumDigits(num);

// PrintResult("Количество цифр в числе " + num + " Равна " + NumDigits(num));
// // Печатаем результат
// void PrintResult(string msg)
// {
//     Console.WriteLine(msg);
// }


////// Решение 2
// Вводим данные
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

int NumDigits(int num)
{
    return Convert.ToInt32(Math.Log(num,10)+1);
}

int num = ReadData("Введите число: ");
Console.WriteLine("Количество цифр в числе " + num + " Равна " + NumDigits(num));