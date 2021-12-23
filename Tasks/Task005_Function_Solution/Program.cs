//Написать программу вычисления значения функции y = f(a). Программа для функции вида k1x^2+k2x+k3 = y и x^3=y

Console.Write("Введите аргумент: ");
int x = int.Parse(Console.ReadLine());    // Аргумент
//int y;                                  // Значение функции


Console.Write("Вы хотите вычислить значение функции квадратного уравнения вида y = k1*x^2 +k2*x +k3? (true/false)");
if (bool.Parse(Console.ReadLine())) 
{
    Console.Write("Введите коэфициент k1: ");
    int k1 = int.Parse(Console.ReadLine());
    Console.Write("Введите коэфициент k2: ");
    int k2 = int.Parse(Console.ReadLine());
    Console.Write("Введите коэфициент k3: ");
    int k3 = int.Parse(Console.ReadLine());

    int y = k1*x*x+k2*x+k3;
    Console.Write("Значение функции квадратного уравнения (" + 
                    k1 + ") * "+ "x^2" + " + " + "(" + k2 + ") * "  + "x" 
                    + " + " + "(" + k3 + ")" +" равно " + y);
}

Console.WriteLine("Вы хотите вычислить значение кубической функции вида y = k1 * x ^3? (true/false)");
if (bool.Parse(Console.ReadLine())) 
{
    Console.Write("Введите коэфициент k1: ");
    int k1 = int.Parse(Console.ReadLine());
    

    int y = k1*x*x*x;
    Console.WriteLine("Значение кубической функции (" + 
                    k1 + ") * "+ "x^3" +" равно " + y);
}
