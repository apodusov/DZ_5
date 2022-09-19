// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.WriteLine("Введите размер массива");
int number = int.Parse(Console.ReadLine());
int[] array = new int[number];

void FindDifferenceArray(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
    Console.WriteLine($"[{string.Join(", ", array)}]");

    int max = array[0];
    int min = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    Console.WriteLine($"Максимальное значение = {max}");

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    Console.WriteLine($"Минимальное значение = {min}");

    int result = max - min;

    Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {result}");
}
FindDifferenceArray(array);