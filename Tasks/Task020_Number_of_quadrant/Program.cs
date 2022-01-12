// Задать номер четверти, показать диапазоны для возможных координат
Console.WriteLine("Введите номер четверти");

switch (Convert.ToInt32(Console.ReadLine())){
    case 1 : 
    Console.WriteLine("Диапазон возможных координат по х от 0 до 100, по у от 0 до 100");
    break;
    case 2 : 
    Console.WriteLine("Диапазон возможных координат по х от 0 до -100, по у от 0 до 100");
    break;
    case 3 : 
    Console.WriteLine("Диапазон возможных координат по х от 0 до -100, по у от 0 до -100");
    break;
    case 4 : 
    Console.WriteLine("Диапазон возможных координат по х от 0 до 100, по у от 0 до -100");
    break;
    default:
    Console.WriteLine("Неверно введен номер квадранта");
    break;
}

