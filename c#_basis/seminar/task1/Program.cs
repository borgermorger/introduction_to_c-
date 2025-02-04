// Напишите программу, которая на вход принимает два целых числа и проверяет первое число квадратом второго.

// a = 25, b = 5      da 
// a = 2, b = 10      njet
// a = 9, b = -3      da 
// a = -3, b = 9      njet

Console.WriteLine("Введите первое целое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a == b * b) {
    Console.WriteLine("Второе число является квадратом первого");
}
else {
    Console.WriteLine("Второе число не является квадратом первого");
}
