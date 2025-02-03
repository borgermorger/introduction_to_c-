// Напишите программу, которая принимает на вход трёхначное число и на выходе показывает сумму первой и последней цифры этого числа:
// 456 => 10
// 782 => 9
// 918 => 17


Console.Write("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

// Проверка на трёхзначность
while (num <=99 || num >= 1000) {
    Console.Write("Это не трёхзначное число, введите заново: ");
    num = Convert.ToInt32(Console.ReadLine());
}

int first_digit = num / 100;
int last_digit = num % 10;

Console.Write($"сумма первой и последней цифры равна: {first_digit + last_digit}");
