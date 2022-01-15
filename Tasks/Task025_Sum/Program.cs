// Найти сумму чисел от 1 до А
int SumNumber(int finalNumber) //Использование рекурсии в качестве обучения. Но более рационально воспользоваться формулой суммы N членов арифмитической прогрессии
{
    if (finalNumber == 1) return 1;
    else return SumNumber(finalNumber - 1) + finalNumber;
}

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(SumNumber(number));







