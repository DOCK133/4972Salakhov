// Напишите прграмму, которая будет принимать 2 числа А и В
// Возведите А в степень В с помощью рекурсии

// // второй вариант:
// // Вывод сообщения и запись введённых данных
// int Prompt(string message)
// {
//     Console.Write(message);
//     string value = Console.ReadLine()??",";
//     int number = Convert.ToInt32(value);

//     return number;
// }
// // Считает сумму
// int Exponentiation(int number, int stepen)
// {
//     return stepen == 2
//     ? number * number
//     : stepen <= 1
//         ? number
//         : stepen % 2 == 0
//             ? Exponentiation(number, stepen / 2) * Exponentiation(number, stepen / 2)
//             : Exponentiation(number, stepen / 2 + 1) * Exponentiation(number, stepen / 2);
// }

// int number = Prompt("Введите число: ");
// int stepen = Prompt("Введите степень: ");

// Console.WriteLine($"Число {number} в степени {stepen} = {Exponentiation(number, stepen)}");

int ReadData(string msg) // вводим данные
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

long MyPow(int a, int b)
{
    if (b == 1)
        return a;
    if (b == 2)
        return a * a;
    if (b > 0)
    // if (b%2==0)
    {
        return MyPow(a, b / 2) * MyPow(a, b - b / 2);
        // Разделение на 2 части (другой способ)
        // return MyPow(a, b / 2) * MyPow(a, b / 2);
    }
    else
        return 1;
        // другой способ
        // return MyPow(a,b/2)*myPow(a,b/2+1);
}
int n = ReadData("Введите основание: ");
int m = ReadData("Введите степень: ");
Console.WriteLine("Число " +n+ " в степени " +m+ " = " + MyPow(n, m));