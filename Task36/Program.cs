// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


Console.Write("Укажите количество элементов массива ");
int num = Convert.ToInt32(Console.ReadLine());
int summ = 0;
int[] arr = new int[num];
Console.Write($"{FillArray(arr)}");
OddSum(arr);
string rev_arr = string.Join(", ", arr);
Console.WriteLine(rev_arr);
Console.Write($"Сумма элементов, стоящих на нечетных позициях: {summ}");
int[] FillArray(int[] mas)
{

    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = new Random().Next(-1000, 1000);
    }
    return mas;
}

int OddSum(int[] b)
{
    for (int j = 1; j < (b.Length / 2);) 
        {
            j = j + 2;
            summ = summ + b[j];
         }
    return summ;
}
