// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите размер массива");
int number = int.Parse(Console.ReadLine());


int[] array = new int[number];

void FindsumArray(int[] array)

{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
    Console.WriteLine($"[{string.Join(", ", array)}]");

    int sum = 0;
    for (int i = 1; i < array.Length; i = i + 2)
    {
        sum = array[i] + sum;
    }

    Console.WriteLine(sum);
}
FindsumArray(array);
