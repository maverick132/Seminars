// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

Console.WriteLine("Проверка утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y");

// Console.Write("Введите значение выражения X (true/false): ");
// bool x = bool.Parse(Console.ReadLine());

// Console.Write("Введите значение выражения Y (true/false): ");
// bool y = bool.Parse(Console.ReadLine());


if (!(true || true) == (!true && !true) &&
     !(true || false) == (!true && !false) &&
     !(false || true) == (!false && !true) &&
     !(false || false) == (!false && !false)
)
{
    Console.Write("Выражение верно");
}
else
{
    Console.Write("Выражение неверно");
}