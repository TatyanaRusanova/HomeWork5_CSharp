// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int[] CreateArray(int [] a)
{
    for (int i = 0; i < a.Length; i ++) a[i] = new Random().Next(-100, 100);
    return a;
}

int OddSum(int[] b)
{
    int sum=0;
    for (int j = 1; j < (b.Length / 2); j = j + 2) sum = sum + b[j];
    return sum;
}

Console.Write("Укажите количество элементов массива ");
int num = Convert.ToInt32(Console.ReadLine());
int[] arr=new int[num];
Console.Write($"Массив ");
Console.WriteLine (string.Join (",", CreateArray(arr)));
OddSum(arr);
Console.WriteLine($"Сумма элементов массива, стоящих на нечетных позициях: {OddSum(arr)}");

