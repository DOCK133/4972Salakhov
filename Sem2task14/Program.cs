// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

Console.WriteLine("Введите число: ");

int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(num % 7 == 0 && num % 23 == 0 ? "Кратно" : "Не кратно");
