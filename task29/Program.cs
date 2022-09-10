// Задача 29: Напишите программу, которая задаёт 
// массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
Console.Clear();

int[] array = new int[8];
int N = array.Length;

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
