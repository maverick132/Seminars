// Написать программу возведения числа А в целую стень B

double NumberPow(int number, int pow)
{
    if (pow == 0) return 1;
    if (pow == 1) return (double)number;
    if (pow > 0) return (double)number * NumberPow(number, pow - 1);
    return 1 / (double)number * NumberPow(number, pow + 1);
}

int number = 2;
int pow = -4;
Console.WriteLine(Math.Round(NumberPow(number, pow), 3));