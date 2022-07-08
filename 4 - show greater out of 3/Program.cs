/*
Напишите программу, которая принимает на вход три числа
и выдаёт максимальное из этих чисел.
*/

Console.WriteLine("Программа для нахождения максимального из трёх целых чисел");
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;
if(num2 > max)
    max = num2;
if(num3 > max)
    max = num3;

if(num1 != num2 || num2 != num3)
    Console.WriteLine("Наибольшее число: " + max);
else
    Console.WriteLine("Введённые числа равны");