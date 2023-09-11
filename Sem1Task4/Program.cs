// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите число 1:");
int num1 = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите число 2:");
int num2 = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите число 3:");

int num3 = int.Parse(Console.ReadLine() ?? "0");

if (num1 >= num2)
{
    if (num1 >= num3)

        Console.Write("Большее число " + num1);
}

else

   if (num2 >= num3)
{
    Console.Write("Большее число " + num2);
}
else
{
    Console.Write("Большее число " + num3);
}
