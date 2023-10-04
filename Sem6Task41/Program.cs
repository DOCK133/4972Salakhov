// Задача 41
// : Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2       --> 2
// -1, -7, 567, 89, 223  --> 3
// (*) Пользователь вводит число нажатий, затем программа следит за нажатиями и выдает сколько чисел больше 0 было введено.

// Вводим данные
int[] InputArrayManually(int M)
{
    int[] arr = new int[M];
    for (int i = 0; i < M; i++)
    {
        Console.Write("Введите " + i + 1 + " элемент: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    for (int i = 0; i < M; i++)
    {
        if (i == M - 1)
            Console.Write(" " +arr[i]+ " -> ");
        else
            Console.Write(" " +arr[i]+ ", ");
    }
    return arr;
}

// Считаем числа
int PositiveNumbersCount(int[] arr)
{
    int counter = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            counter++;
        }
    }
    Console.Write(counter);
    return counter;
}

PositiveNumbersCount(InputArrayManually(5));
