// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int ReadInt(string message)
{
    System.Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}

int Sum(int first, int second)
{
    if (first > second)
    {
        return 0;
    }

    return second + Sum(first, second - 1);
}

int M = ReadInt($"Задайте число M");
int N = ReadInt($"Задайте число N");
System.Console.WriteLine($"Сумма натуральных элементов в промежутке от {M} до {N}: ");
System.Console.WriteLine(Sum(M, N));