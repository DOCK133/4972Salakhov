﻿// // Задача 41
// // : Пользователь вводит с клавиатуры M чисел.
// // Посчитайте, сколько чисел больше 0 ввёл пользователь.
// // 0, 7, 8, -2, -2       --> 2
// // -1, -7, 567, 89, 223  --> 3
// // (*) Пользователь вводит число нажатий, затем программа следит за нажатиями и выдает сколько чисел больше 0 было введено.

// // Вводим данные
// int[] InputArrayManually(int M)
// {
//     int[] arr = new int[M];
//     for (int i = 0; i < M; i++)
//     {
//         Console.Write("Введите " + i + 1 + " элемент: ");
//         arr[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     for (int i = 0; i < M; i++)
//     {
//         if (i == M - 1)
//             Console.Write(" " +arr[i]+ " -> ");
//         else
//             Console.Write(" " +arr[i]+ ", ");
//     }
//     return arr;
// }

// // Считаем числа
// int PositiveNumbersCount(int[] arr)
// {
//     int counter = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] > 0)
//         {
//             counter++;
//         }
//     }
//     Console.Write(counter);
//     return counter;
// }

// PositiveNumbersCount(InputArrayManually(5));


﻿//------------------------------------------------------------------------------------------------------------------
//                                                  Задача 41
//                                          Домашнее задание к семинару 06
//   Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//   (*) Пользователь вводит число нажатий, затем программа следит за нажатиями и выдает сколько чисел больше 0 было введено.
//------------------------------------------------------------------------------------------------------------------

//                                                 Тело программы
//------------------------------------------------------------------------------------------------------------------
using System.Text.RegularExpressions;
Console.Clear();

int numOfKeyPresses = ReadInt("Введите количество нажатий: ");  // Ввод пользователем количества нажатий.
string data = KeyPresses("Введите строку: ", numOfKeyPresses);  // Получение нажатий с клавиатуры.
//Console.WriteLine(data);
int count = CountPositiveNumbers(data);                         // Подсчет положительных чисел в строке.
PrintResult($"\nВведено чисел больше нуля: {count}");           // Вывод результата в консоль.

//                                                     Методы
//------------------------------------------------------------------------------------------------------------------

// Ввод целого числа с клавиатуры.
int ReadInt(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Получение нажатий с клавиатуры.
string KeyPresses(string msg, int numOfKeyPresses)
{
    Console.Write(msg);
    string data = string.Empty;
    
    for (int i = 0; i < numOfKeyPresses; i++)
    {
        var keyInfo = Console.ReadKey();
        data += keyInfo.KeyChar;
    }

    return data;
}

// Подсчет положительных чисел в строке с использованием регулярных выражений.
int CountPositiveNumbers(string input)
{
    string pattern = @"[-]?[0-9]+";
    MatchCollection matches = Regex.Matches(input, pattern);

    int count = 0;
    foreach (Match match in matches)
    {
        if (int.Parse(match.Value) > 0) { count++; }
    }
    return count;
}

// Вывод результата в консоль.
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}