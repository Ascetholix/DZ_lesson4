// Задача 27: Напишите программу, которая принимает на вход число
//  и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.Clear();

Console.Write("Введите число : ");
int num = Convert.ToInt32(Console.ReadLine());

int numPart = 0;
int sum = 0;

for (int i = 0; num != 0; i++)
{
    numPart = num % 10;
    num /= 10;
    sum += numPart;
}
Console.WriteLine($"{num} сумма цифр равно: {sum}");