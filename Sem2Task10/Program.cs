﻿// №10 Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int ran = new System.Random().Next(100, 1000);
//<Берем переменную><создаем рандомное трехзначное числочисло>
System.Console.WriteLine(ran);
//Показываем число в терминале
char[] digitChar = ran.ToString().ToCharArray();
//<создаем массив><вкладываем число и превращаем в массив><превращаем строку в массив char>
System.Console.Write(digitChar[1]);
//показываем вторую цифру в терминале