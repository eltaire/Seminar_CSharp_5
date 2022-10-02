// Задача 35: Задайте одномерный массив из 123 случайных чисел. Напишите количество элементов в отрезке [10,99]

void FillArray(int[] array, int min, int max)
{
    int length = array.Length;
    for(int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min,max+1);
    }
}
string StringArray(int[] array, string split)
{
    int length = array.Length;
    string textarray = String.Empty;
    for(int i = 0; i < length; i++)
    {
        textarray += array[i];
        if(i < length - 1)
        {
            textarray += split;
        }
    }
    return textarray;
}

int FindNumber(int[] arr, int find)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 10 && arr[i] < 99)
            sum ++;
    }
    return sum;
}
int[] array = new int[123];
FillArray(array, -100, 100);
 
int number = 0;
Console.WriteLine("В массиве [" + StringArray(array,", ") + "]  " + FindNumber(array,number) + " чисел из промежутка [10, 99]");
