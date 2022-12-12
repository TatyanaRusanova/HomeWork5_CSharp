// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
double[] CreateArray(int lenght)
{
    double[] array = new double[lenght];
    for (int i = 0; i < lenght; i ++){
        array[i] = Math.Round((new Random().NextDouble() * 100), 2);
        if (i < lenght - 1) Console.Write($"{array[i]},  ");
        else Console.WriteLine($"{array[i]}");
    }
    return array;
}

void Diff(double[] array)
{
    double min = array[0];
    double max = array[0];
    double diff = 0;
    for (int i = 1; i < array.Length; i ++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    diff = max - min;
    Console.WriteLine(Math.Round(diff, 2));
}
double[] num = CreateArray(10);
Console.WriteLine("Разница между максимальным и минимальным элементами массива равна  ");
Diff(num);
