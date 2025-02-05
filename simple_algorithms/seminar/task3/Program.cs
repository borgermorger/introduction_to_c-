// Напишите программу, которая будет принимать на вход два числа и выводить, является ои первое число кратным второму. 
// Если первое число не кратное второму, то программа выводит остаток от деления.

// Примеры 

// 14, 5 => нет, 4
// 16, 8 => да
// 4, 3 => нет, 1

Console.Write("Введите первое положительное число: ");
int first_num = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе положительное число: ");
int second_num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("является ли первое число кратным второму?");
int remainder = first_num % second_num;
if (remainder == 0) {
    Console.WriteLine("да, является");
}
else {
    Console.WriteLine($"нет, есть остаток равный: {remainder}");
}