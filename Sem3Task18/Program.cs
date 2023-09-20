// ЗАДАНИЕ 18
// Напишите программу, которая по заданному номеру четверти, 
// показывает диапозон возможных координат точек вэтой четверти (X и Y)

// 1) Ввести номер четверти
// 2) Ответить на вопрос
// 3) Вывести ответ


// Вводим данные
int ReadData()
{
    Console.WriteLine("Введите номер четверти: ");
    return Convert.ToInt32(Console.ReadLine());
}

string QuterBorderAsk(int numQuter)
{
    if (numQuter == 1) return "x>0, y>0";
    if (numQuter == 2) return "x>0, y<0";
    if (numQuter == 3) return "x<0, y<0";
    if (numQuter == 4) return "x<0, y>0";
    return "Неверное значение";
}

// Печатаем результат
int numQuter = ReadData();
Console.WriteLine(QuterBorderAsk(numQuter));