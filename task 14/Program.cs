// Задача 14: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.WriteLine("Введите число");
int A = Convert.ToInt32(Console.ReadLine());


if(A % 7 == 0 && A % 23 == 0)
    Console.WriteLine("Кратно");
    else
    Console.WriteLine($"{A} Не кратно 7 и 23");
