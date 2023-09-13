// №10 Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

    int ran = new System.Random().Next(100, 1000);
    System.Console.WriteLine(ran);
    char[] digitChar = ran.ToString().ToCharArray();
    System.Console.Write(digitChar[1]);