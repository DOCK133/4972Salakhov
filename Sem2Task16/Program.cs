// Напишите программу, котора принимает на вход два числа и проверяет, является ли одно число квадратом другого.

Console.Write("Введите число 1: ");

int numA = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите число 2: ");

int numB = int.Parse(Console.ReadLine() ?? "0");

bool test1 = (numA == numB * numB);

bool test2 = (numB == numA * numA);

if (test1)Console.WriteLine("Первое квадрат второго");

if (test2)Console.WriteLine("Второе квадрат первого");

if (!(test1||test2))
{
    Console.WriteLine("Числа не квадраты друг другу");
}
