﻿// Задание 3
// Определение, является ли число положительным
// Описание: Напишите метод, который на вход принимает число и выводит, является ли
// оно положительным (больше нуля), отрицательным (меньше нуля) или нулём.
// Пример использования: На входе:
// ● number: 7
// На выходе:
// ● положительное
// На входе:
// ● number: -3
// На выходе:
// ● отрицательное
// На входе:
// ● number: 0
// На выходе:
// ● ноль

Console.Write("Введите целое число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a == 0) {
    Console.Write("ноль");
}
if (a > 0) {
    Console.Write("положительное");
}
if (a < 0) {
    Console.Write("отрицательное");
}