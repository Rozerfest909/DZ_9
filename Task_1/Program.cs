// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"


int ReadInt(string message)
{
    System.Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}

void Print(int first, int second)
{
    if (first > second)
    {
        return;
    }

    if (first % 2 == 1)
    {
        first++;
    }

    System.Console.WriteLine(first);
    Print(first + 2, second);
}

int M = ReadInt($"Задайте число M");
int N = ReadInt($"Задайте число N");
System.Console.WriteLine($"Натуральные числа в промежутке от {M} до {N}: ");
Print(M, N);