string[] Week = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};

Console.Write("Введите номер дня недели: ");
int day = int.Parse(Console.ReadLine());
Console.Write("День недели с номером " + day + " это " + Week[day-1]);


