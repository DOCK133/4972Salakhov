// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите число 1:");
int num1 = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите число 2:");
int num2 = int.Parse(Console.ReadLine() ?? "0");

if (num1 > num2)
{
    Console.WriteLine("Большее число " + num1 + " Меньшее число " + num2);
}
else
{
    Console.WriteLine("Большее число " + num2 + " Меньшее число " + num1);
}
