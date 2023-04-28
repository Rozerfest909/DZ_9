// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

int ReadInt(string message)
{
    System.Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}

int Akk(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (n == 0)
    {
        return Akk(m - 1, 1);
    }
    return Akk(m - 1, Akk(m, n - 1));
}

int M = ReadInt($"Задайте число M");
int N = ReadInt($"Задайте число N");
System.Console.WriteLine($"Значение вычисления функции Аккермана: ");
if (M > -1 && N > -1)
{
    System.Console.WriteLine(Akk(M, N));
}
else
{
    System.Console.WriteLine("Вы ввели отрицательное число");
}
