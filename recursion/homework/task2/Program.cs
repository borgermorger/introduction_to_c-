// Задача 2: Функция Аккермана
// Описание: Напишите программу для вычисления функции Аккермана с помощью
// рекурсии. Даны два неотрицательных числа m и n.
// Пример:
// ● Вход: m = 2, n = 3
// ● Выход: A(m, n) = 29
// ● Вход: m = 1, n = 4
// ● Выход: A(m, n) = 7

int AkkermanFunction(int m, int n) {
    if (m < 0 || n < 0) {
        Console.WriteLine("Пошел нахуй пидарас");
        return 0;
    }
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return AkkermanFunction(m -1, 1);
    if (m > 0 && n > 0) return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
    return 0;
}

Console.WriteLine("Введите первую цифру: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую цифру: ");
int secondNum = Convert.ToInt32(Console.ReadLine());

int result = AkkermanFunction(firstNum, secondNum);
if (result != 0) {
    Console.Write($"Резултат функции Аккермана: {result}");
}
else {
    Console.WriteLine("Ты шо чупашила?");
}