// Задача 29: Напишите программу, которая задаёт 
// массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
Console.Clear();

Console.Write("Введите длину массива число 8: ");
int N = Convert.ToInt32(Console.ReadLine());

int[] array = new int[N];

if (N == 8) // Если условия True то викторина
{
    for (int i = 0; i < N; i++)
    {
        array[i] = new Random().Next(0, 10);

        if (array[i] == 2) array[i] = 12345; // Простое условие 

        if (array[i] == 5)         // Условие если 5 то победа
        {
            array[i] = 1000000;
            Console.WriteLine("Урааа!!! Ты победил");
        }
        Console.WriteLine(array[i]);
    }
}
else
{
    Console.WriteLine("Очень жаль вы ввели не правельное число. ");
}