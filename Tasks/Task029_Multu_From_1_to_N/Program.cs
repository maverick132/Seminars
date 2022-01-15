// Написать программу вычисления произведения чисел от 1 до N
long Multy(int number) {
    if (number == 1) return 1;
    return number*Multy(number-1);
}

Console.WriteLine("Введите число");

int numb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Произведение чисел от 1 до {numb} равно {Multy(numb)}");
