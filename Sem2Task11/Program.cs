//Напишите программу, которая выводит случайное трёхзначное число, и удаляет вторую цифру этого числа.

void Variant1()
{
    int num = new Random().Next(100, 100);
    Console.WriteLine(num);
    int firstDigit = num / 100;
    int lastDigit = num % 10;
    num = firstDigit * 10 + lastDigit;
    Console.WriteLine(num);
}

void Variant2()
{
    int ran = new System.Random().Next(100, 1000);
    System.Console.WriteLine(ran);
    char[] digitChar = ran.ToString().ToCharArray();
    System.Console.Write(digitChar[0]);
    System.Console.Write(digitChar[2]);
}


Variant1();
Variant2();
