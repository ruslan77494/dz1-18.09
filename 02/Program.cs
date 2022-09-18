/*
Задача 2: Напишите программу, которая на вход 
принимает два числа и выдаёт, какое число большее,
 а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
Console.WriteLine("Пожалуйста введите число 1 ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Пожалуйста введите число 2 ");
int numberB = int.Parse(Console.ReadLine());
int max = 0;
int min = 0;
int a = numberA;
int b = numberB;
 if (a > max) max = a;
 if (b > a ) min = a;
 if (b > max) max = b;
 if(a > b) min = b;

Console.Write($" max -> {max}   min ->{min}  ");

