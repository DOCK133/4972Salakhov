// // Задача 22
// //Напишите программу которая принимает на вход число (N) и выдает таблицу квадратов от 1 до N

// // 1) ReadData
// // 2) BuildLine
// // 3) PrintResult


// // МЕТОД 1
// int ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     int num = int.Parse(Console.ReadLine() ?? "0");
//     return num;
// }
// string BuildLine(int num, int pow)
// {
//     string res = string.Empty;
//     for (int i = 1; i <= num; i++)
//     {
//         res = res + Math.Pow(i, pow) + " ";
//     }
//     return (res);
// }
// void PrintResult(string msg)
// {
//     Console.WriteLine(msg);
// }
// int num = ReadData("Введите число");
// PrintResult(BuildLine(num, 1));
// PrintResult(BuildLine(num, 3));

// //// МЕТОД 2

void Prompt(string message)
{
    Console.WriteLine(message);
    string values = Console.ReadLine() ?? "0";
    int number = Convert.ToInt32(values);

    OutputSquares(number);
}

void OutputSquares(int number)
{
    Console.Clear();

    int currentNumber = 0;
    int currentNumberSquare;
    int cursor = 0;

    while (currentNumber <= number)
    {
        currentNumberSquare = (int)Math.Pow(currentNumber, 2);

        Console.SetCursorPosition(cursor, 0);
        Console.Write(currentNumber);

        Console.SetCursorPosition(cursor, 1);
        Console.Write(currentNumberSquare);

        cursor = Console.CursorLeft + 3;

        currentNumber++;
    }
}

Prompt("Введите число: ");