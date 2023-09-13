void Variant1()
{
    Console.WriteLine("Введите число1: ");

    int numA = int.Parse(Console.ReadLine() ?? "0");

    Console.WriteLine("Введите число2: ");

    int numB = int.Parse(Console.ReadLine() ?? "0");
    if (numB % numA == 0)
    {
        Console.WriteLine("второе число кратно первому");
    }
    else
    {
        Console.WriteLine("второе число не кратно первому, остаток от деления " + numB % numA);
    }
}

void Variant2()
{
    int a = int.Parse(Console.ReadLine() ?? "0");
    int b = int.Parse(Console.ReadLine() ?? "0");

    Console.WriteLine((a % b == 0) ? true : a % b);
}



Variant1();
Variant2();