// Программа проверяет пятизначное число на палиндромом.
Console.WriteLine("Введите число или слово для проверки на палиндром");
string data = Console.ReadLine();

if (CheckPalindrom(data)) {
    Console.WriteLine($"Введенное число или слово {data} является палиндромом");
}
else {
    Console.WriteLine($"Введенное число или слово {data} не является палиндромом");
}

bool CheckPalindrom(string palindrom)
{
    
    for (int i = 0; i <= palindrom.Length / 2; i++)
    {
        if (palindrom[i] != palindrom[palindrom.Length - 1 - i])
        {
            return false;
        }
    }
    return true;
}

