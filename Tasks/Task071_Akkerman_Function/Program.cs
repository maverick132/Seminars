// Написать программу вычисления функции Аккермана

int AckermanFunction(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0) return AckermanFunction(m - 1, 1);
    return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
}

int m = 4;
int n = 0;
Console.WriteLine(AckermanFunction(m, n));