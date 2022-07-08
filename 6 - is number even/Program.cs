/*
Напишите программу, которая на вход принимает число и выдаёт,
является ли число чётным (делится ли оно на два без остатка).
*/

Console.WriteLine("Программа для определения, является ли число чётным");
Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number % 2 == 0)
    Console.WriteLine("Число чётное");
else
    Console.WriteLine("Число нечётное");
