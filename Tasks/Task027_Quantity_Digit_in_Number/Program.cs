// Определить количество цифр в числе
Console.WriteLine("Введите число:");
String number = Console.ReadLine() ?? String.Empty;
Console.WriteLine($"Количество цифр в числе {number} равно {number.Length}");
