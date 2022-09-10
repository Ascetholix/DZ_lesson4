// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
//  и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.Write("Введите число А : ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B : ");
int b = Convert.ToInt32(Console.ReadLine());

int res = 1;

for (int i = 0; i < b; i++)
{
    res *= a;
}
Console.WriteLine($"{a} в степени {b} = {res}");