// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

Console.Write("Введите число от 10 до 99 ");
string number = Console.ReadLine();
if (Char.GetNumericValue(number[0]) > Char.GetNumericValue(number[1]))
{
    Console.Write("Максимальная цифра в данном числе: " + Char.GetNumericValue(number[0]));
}
else
{
    if (Char.GetNumericValue(number[0]) == Char.GetNumericValue(number[1]))
    {
        Console.Write("Обе цифры равны: " + Char.GetNumericValue(number[0]));
    }

    else
    {
    Console.Write("Максимальная цифра в данном числе: " + Char.GetNumericValue(number[1]));
    }
}       
        
    




