// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.


Console.Write("Укажите количество элементов массива ");
int num = Convert.ToInt32(Console.ReadLine());
double[] arr = new double[num];

FillArray(arr);
string rev_arr = string.Join(", ", arr);
Console.WriteLine(rev_arr);
double min=arr[0];
double max=arr[0];
for( int i= 0; i < arr.Length; i++)
{
    if(arr[i]>max) max=arr[0];
    else if (arr[i]<min) min=arr[i];
} 
Console.Write($"Разность максимума {Math.Round(max,2)}");
Console.WriteLine($" и минимума {Math.Round(min,2)} равна {Math.Round((max-min),2)}");

double[] FillArray(double[] mas)
{

    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = new Random().NextDouble()*10;
    }
    return mas;
}

