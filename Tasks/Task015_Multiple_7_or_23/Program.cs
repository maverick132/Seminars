// Дано число. Проверить кратно ли оно 7 и 23

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

if (number % 7 == 0 || number % 23 == 0)
{
    if (number % 7 == 0 && number % 23 != 0)
    {
        Console.WriteLine("Число кратно 7");
        
    }

    if (number % 7 != 0 && number % 23 == 0)
    {
        Console.WriteLine("Число кратно 23");
        
    }

    if (number % 7 == 0 && number % 23 == 0)
    {
        Console.WriteLine("Число кратно 7 и 23");
        
    }
}
else {
     Console.WriteLine("Число некратно ни 7, ни 23");
}
