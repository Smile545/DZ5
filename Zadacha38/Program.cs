// // Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

double[] Fillarray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
    }
    return array;
}
Console.WriteLine("Введите длину массива");
int a = Convert.ToInt32(Console.ReadLine());

double[] array = new double[a];

array = Fillarray(array);
Console.WriteLine(string.Join(", ", array));

double min = array[0];
double max = 0;

for (int i = 1; i < array.Length; i++)
{
    if (min > array[i])
    {
        min = array [i];
    }
    else if (max < array[i])
    {
        max = array[i];
    }
}
double result = max - min;
Console.WriteLine(result);