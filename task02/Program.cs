// Задача 66: Задайте значения M и N. Напишите программу, которая 
// найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

bool Validate(int m, int n)
{
    return (m < n);
}

int GetSequence(int m, int n)
{
    if (m == n) return m;
    else return n + GetSequence(m, n - 1);
}

int GetNum(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int numM = GetNum("Введите число M: ");
int numN = GetNum("Введите число N: ");
if (Validate(numM, numN))
    Console.Write($"M = {numM}; N = {numN} -> {GetSequence(numM, numN)}");
else
    Console.Write("Число M должно быть меньше N.");