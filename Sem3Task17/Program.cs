// ЗАДАЧА 17
// Напишите программу, которая принимает на вход координаты точки ( X и Y ), причем X = 0 и Y = 0 и 
// выдает номер плоскости четверти, в которой находится эта точка.

// 1) Ввести X
// 2) Ввести Y
// 3) Поиск ответа
// 4) Вывести результат

// Вводим данные
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

// По координатам точки определяем номер четверти
int QuterTest(int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return 0;
}

// Печатаем результат
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}


int x = ReadData("Введите координату X: ");
int y = ReadData("Введите координату Y: ");

int res = QuterTest(x, y);

PrintResult("Точка находится в четверти № " + res);