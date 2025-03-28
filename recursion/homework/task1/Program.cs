// Задача 1: Вывод натуральных чисел в промежутке от M до N
// Описание: Напишите программу, которая выведет все натуральные числа в
// промежутке от M до N. Используйте рекурсию и не используйте циклы.
// Пример:
// ● Вход: M = 1, N = 5
// ● Выход: 1, 2, 3, 4, 5
// ● Вход: M = 4, N = 8
// ● Выход: 4, 5, 6, 7, 8

void PrintNaturalNum(int firstNum, int secondNum) {
    if (firstNum > secondNum) {
        Console.WriteLine("Первая цифра не может быть больше второй"); 
        return;
    }
    if (firstNum == secondNum) {
        Console.Write(secondNum); 
        return;
    }
    Console.Write($"{firstNum} ");
    PrintNaturalNum(firstNum + 1, secondNum);
}

Console.WriteLine("Введите первую цифру: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую цифру: ");
int secondNum = Convert.ToInt32(Console.ReadLine());

PrintNaturalNum(firstNum, secondNum);