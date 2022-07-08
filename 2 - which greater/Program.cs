/*
Напишите программу, которая на вход принимает два числа
и выдаёт, какое число большее, а какое меньшее
*/

Console.WriteLine("Программа для сравнения двух целых чисел");
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
{
    int temp = num1;
    num1 = num2;
    num2 = temp;
}

if(num1 != num2)
    Console.WriteLine(num1 + " меньше, чем " + num2);
else
    Console.WriteLine("Введённые числа равны");