﻿// Напишите программу, которая выводит третью слева цифру заданного числа или сообщает, что третей цифры нет.

// примеры 

// 456 => 6
// 7812 => 1
// 91 => Третьей цифры нет

Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num <= -100 || num >= 100) {
    while (num <= -1000 || num >= 1000) {
        num /= 10;
    }  
    int result = num % 10;
    Console.Write($"Третье цифра введенного числа: {result}");
}
else {
    Console.Write($"Третье цифры нету");
}