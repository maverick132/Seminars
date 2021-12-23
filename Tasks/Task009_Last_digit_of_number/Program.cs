// Показать последнюю цифру трёхзначного числа

Console.Write("Введите число от 100 до 999 ");
int number= int.Parse(Console.ReadLine());


Console.Write(number.ToString()[2]);
