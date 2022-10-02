// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Console.WriteLine("Введите размер массива:  ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное число массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное число массива: ");
int max = Convert.ToInt32(Console.ReadLine());

void FillArray(double[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        a[i] = new Random().Next(min,max);
    }
}

void PrintArray(double[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        Console.Write(a[i] + " ");
    }
    Console.WriteLine();
}

double GetMaxx(double[] a)
{
    double maxx = min;
    for (int i = 0; i < a.Length; i ++)
    {
        if (a[i] > maxx)
            maxx = a[i];
    }
    return maxx;
}

double GetMinn(double[] a)
{
    double minn = max;
    for (int i = 0; i < a.Length; i ++)
    {
        if (a[i] < minn)
            minn = a[i];
    }
    return minn;
}
double[] array = new double[size];
FillArray(array);
PrintArray(array);
// double c = GetMaxx(array);
// double b = GetMinn(array);
// double d = GetMaxx(array) - GetMinn(array);
Console.WriteLine("Разница между максимальным и минимальным элементами Вашего массива равна " + (GetMaxx(array) - GetMinn(array)));