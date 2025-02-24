﻿//Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента


void FillArray3D(int[,,] array) //Заполнение трехмерного массива не повторяющимися двузначными числами
{
    int number = 21;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = number;
                number++;
            }
        }
    }
}

void PrintArray3D(int[,,] array) //Вывод двумерного массива
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.WriteLine($"Элемент с индексом [{i}, {j}, {k}] - {array[i, j, k]}.");

            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


int[,,] array = new int[4, 4,4];

FillArray3D(array);
PrintArray3D(array);

