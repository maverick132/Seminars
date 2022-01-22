// Определить сколько чисел больше 0 введено с клавиатуры
Console.WriteLine("Вводите числа через enter. Введите слово end для остановки. ");

string ReadOnConsole = Console.ReadLine() ?? String.Empty;
int countNumber = 0;

while (ReadOnConsole.ToUpper() != "END" && ReadOnConsole.ToUpper() != String.Empty)
{
    int number = Convert.ToInt32(ReadOnConsole);
    if (number > 0) countNumber++;
    ReadOnConsole = Console.ReadLine() ?? String.Empty;
}
Console.WriteLine($"Введено {countNumber} больше 0");