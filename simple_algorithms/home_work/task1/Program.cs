// Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.


Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 7 == 0 && num % 23 == 0) {
    Console.WriteLine($"Число {num} кратно 7-и и 23-ем");
}
else {
    Console.WriteLine($"Число {num} не кратно 7-и и 23-ем");
}