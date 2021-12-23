// Удалить вторую цифру трёхзначного числа

Console.Write("Введите число от 100 до 999 ");
string number = Console.ReadLine();
number = number.Remove(1,1);
Console.Write(number);

