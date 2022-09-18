/*
Напишите программу, которая принимает
 на вход три числа 
и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
Console.WriteLine(" Пожалуйста введите первое число : ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Пожалуйста введите второе число : ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Пожалуйста введите третье число : ");
int n2 = Convert.ToInt32(Console.ReadLine());

int a = n;

int b = n1;

int c = n2;

int max = 0;

if (b > max) max = b;

if (c > max) max = c;

if (a > max)  max = a; 

Console.WriteLine($"Ответ -->  {max}");


