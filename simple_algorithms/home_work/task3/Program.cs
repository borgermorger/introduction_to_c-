// Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.


Console.Write("Введите целое число в промежутке от 10 до 99 включительно: ");
int num = Convert.ToInt32(Console.ReadLine());

while (num > 99 || num < 10) {
    Console.Write("Некоррректный ввод. Введите целое число в промежутке от 10 до 99 включительно: ");
    num = Convert.ToInt32(Console.ReadLine());
}

int first_digit = num / 10;
int second_digit = num % 10;

if (first_digit >= second_digit) {
    Console.WriteLine($"Наибольщая цифра равна: {first_digit}");
}
else {
    Console.WriteLine($"Наибольщая цифра равна: {second_digit}");
}