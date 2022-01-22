// Выяснить являются ли три числа сторонами треугольника 

Console.WriteLine("Введите первое число");
int sideAB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int sideBC = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int sideCA = Convert.ToInt32(Console.ReadLine());

if (sideAB+sideBC > sideCA && sideCA+sideBC > sideAB  && sideAB+sideCA > sideBC) Console.WriteLine("Числа являются стронами треугольника");
else Console.WriteLine("Числа не являются стронами треугольника");