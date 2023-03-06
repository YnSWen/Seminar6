// Задача 41:  Пользователь вводит с клавиатуры M чисел. Посчитайте,
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.Write($"Введите количество элементов: ");
int size = Convert.ToInt32(Console.ReadLine());


int[] InputArray (int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine ($"Введите {i + 1} элемент ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;

}

int[] array = InputArray(size);

int Count (int[] array)
{
    int count = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int count = Count(array);

Console.WriteLine($"{String.Join("; ", array )}");

Console.WriteLine($"Количество чисел больше 0: {count}");
