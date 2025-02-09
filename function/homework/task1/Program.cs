// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. Программа завершается при вводе 
// символа ‘q’ или при вводе числа, сумма цифр которого чётная.

// Мое решение
bool IsItQ (string str) {
    if (str == Convert.ToString('q')) {
        return true;
    }
    return false;
}

bool IsEvenNum(int num) {
    if (num % 2 == 0) {
        return true;
    }
    return false;
}

bool stop = true;
while(stop) {
    Console.WriteLine("Введите целое число: ");
    string input = Console.ReadLine();
    if (IsItQ(input)) {
        stop = false;
        continue;
    }
    int num = Convert.ToInt32(input);
    if (IsEvenNum(num)) {
        stop = false;
    }
}

// Эталонне решение это, но хз почему. Тут нету ни одной функции, а этот урок посвящено функции и там где та ошибка есть.
// using System;
// class Program
// {
// static void Main()
// {
// while (true) // Бесконечный цикл
// {
// Console.Write("Введите число или 'q' для выхода: ");
// string input = Console.ReadLine(); // Чтение строки ввода пользователя
// if (input == "q") // Проверка на ввод 'q' для выхода
// {
// break;
// }
// int number;
// if (int.TryParse(input, out number)) // Проверка, является ли ввод числом{
// int sum = 0;
// while (number > 0) // Вычисление суммы цифр числа
// {
// sum += number % 10; // Добавление последней цифры к сумме
// number /= 10; // Удаление последней цифры из числа
// }
// if (sum % 2 == 0) // Проверка, является ли сумма цифр четной
// {
// Console.WriteLine("[STOP]");
// break;
// }
// }
// else // Если ввод не является числом и не 'q', повторить запрос
// {
// Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое числоили 'q'.");
// }
// }
// }
// }