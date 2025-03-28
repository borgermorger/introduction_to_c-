// Задание 2 

// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр

// Указание испольвать рекурсию

// Пример
// 123 => 6
// 63 => 9

int ReturnSumOfDigits(int num) {
    if (num == 0) return 0;
    return num % 10 + ReturnSumOfDigits(num / 10);
}

Console.WriteLine("Введите натуральное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int result = ReturnSumOfDigits(num);
Console.WriteLine(result);