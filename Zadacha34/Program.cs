// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
//  которая покажет количество чётных чисел в массиве


int[] Fillaray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

int[] array = new int[3];

array = Fillaray(array);
Console.WriteLine(string.Join(", ", array));
int sumChetnih = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
        sumChetnih = sumChetnih + 1;
}

Console.WriteLine($"Количество четных чисел равно {sumChetnih}");