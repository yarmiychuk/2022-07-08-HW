/*
Напишите программу, которая на вход принимает число (N),
а на выходе показывает все чётные числа от 1 до N.
*/

Console.WriteLine("Программа для отображения всех чётных чисел от 1 до введённого");
Console.Write("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number <= 1)
    Console.WriteLine("Вы ввели неправильное число");
else
{
    int current = 2;
    while (current <= number)
    {
        Console.Write(current + " ");
        current += 2;
    }
    // Строчка для корректного отображения в терминале после завершения работы )))
    Console.WriteLine();
}
