// Напишите программу, которая на вход принимает целое число N, а на выходе показывает все целые числа промежутка -N до N.

// Примеры: 4, 2


using System;

Console.WriteLine("Введите целое число: ");
int digit = Convert.ToInt32(Console.ReadLine());

if (digit < 0){
    digit = -digit;
}
int count = -digit;
while (count <= digit) {
    Console.Write($"{count} ");
    count++;
}
