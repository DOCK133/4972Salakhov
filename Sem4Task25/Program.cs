// №25 Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// (задание со *) Написать калькулятор с операциями +, -, /, * и возведение в степень

// Вводим данные
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}
// Метод возведения в степень
long MyPow(int A, int B)
{
    long res = 1;
    while (B > 0)
    {
        res = res * A;
        B = B - 1;
    }
    return res;
}
// Печатаем результат
int A = ReadData("Введите число1: ");
int B = ReadData("Введите число2: ");
long res = MyPow(A, B);
PrintResult(A + " в степени " + B + " = " + res);

void PrintResult(string msg)
{
    Console.WriteLine(msg);
}