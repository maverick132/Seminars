// Возведите число А в натуральную степень B используя цикл
Double AscensionToDegree(int basis, int degree) // Однако тип Double не точен, при больших вычислениях
{
    Double result = (double)basis;
    
    for (int i = 1; i < Math.Abs(degree); i++)
    {
                result *= basis;
    }
    return degree >=0 ? result : 1/result;
    

}


Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine()  ?? String.Empty);
Console.WriteLine("Введите степень:");
int degree = Convert.ToInt32(Console.ReadLine()  ?? String.Empty);

System.Console.WriteLine($"Число {number} в степени {degree} равно {AscensionToDegree(number, degree)}");

