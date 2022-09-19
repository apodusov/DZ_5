// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Введите размер массива");
int number = int.Parse(Console.ReadLine());

int[] array = new int[number];

void FindevenArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(99, 1000);
}

Console.WriteLine($"[{string.Join(", ", array)}]");

int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        count++;
    }
}

Console.WriteLine($"Количество четных чисел = {count}");
}
FindevenArray(array);