// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


Console.Write("Укажите количество элементов массива ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 0;
int[] arr = new int[num];


int[] FillArray(int[] mas)
{

    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = new Random().Next(100, 1000);
        if (mas[i] % 2 == 0) count++;
    }
    return mas;
}


Console.Write($"Массив {FillArray(arr)}");

string rev_arr = string.Join(", ", arr);
Console.WriteLine(rev_arr);

Console.Write($"В массиве {count} четных чисел");