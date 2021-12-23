// Найти третью цифру числа или сообщить, что её нет

Console.Write("Введите число: ");

string numberString = Console.ReadLine();

if (numberString.Contains("-"))
{
    numberString = numberString.Remove(0, 1);
}

if (numberString.Length > 2)
{
    int number = int.Parse(numberString);
    Console.Write("Третья цифра данного числа: " + int.Parse(numberString).ToString()[2]);
}
else
{
    Console.Write("В данном числе нету третьей цифры");
}

