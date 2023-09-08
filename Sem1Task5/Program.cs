Console.WriteLine("Введите число");
int numN = int.Parse(Console.ReadLine() ?? "0");
int evNumN = (-1) * numN;

while (evNumN < numN)
{
    Console.Write(evNumN + ",");
    evNumN = evNumN + 1;
}
Console.WriteLine(numN);
