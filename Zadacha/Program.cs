// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.


int[] Fillarray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
    return array;
}
Console.WriteLine("Введите длину массива");
int a = Convert.ToInt32(Console.ReadLine());

int[] array = new int[a];

array = Fillarray(array);
Console.WriteLine(string.Join(", ", array));

int sum = 0;
for (int i = 1; i < array.Length; i+=2)
{
    sum = sum + array[i];
}
Console.WriteLine($"Сумма элементов равна {sum}");