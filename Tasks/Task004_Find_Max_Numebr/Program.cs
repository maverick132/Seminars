int[] numbers = new int[3];
Console.Write("Введите первое число: ");
numbers[0] = Int32.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
numbers[1] = Int32.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
numbers[2] = Int32.Parse(Console.ReadLine());

BubbleSort(numbers);

Console.WriteLine("Максимальное число это - " + numbers[0]);

static int[] BubbleSort(int[] array) //Пузырьковая сортировка
        {
            int temp;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }                   
                }            
            }
            return array;
        }
