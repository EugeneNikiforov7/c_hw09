// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int FuncAkkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else
    {
        if (m > 0 & n == 0) return FuncAkkerman(m - 1, 1);
        else return FuncAkkerman(m - 1, FuncAkkerman(m, n - 1));
    }
}

int GetNum(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int numM = GetNum("Введите число M: ");
int numN = GetNum("Введите число N: ");
Console.Write($"M = {numM}; N = {numN} -> A({numM}, {numN}) = {FuncAkkerman(numM, numN)}");