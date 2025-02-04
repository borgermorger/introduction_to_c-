// Напишите программу которая принимает на вход трёхзначаное число и удаляет вторую цифру этого числа.

// примеры 

// а = 256 = > 26
// a = 891 => 81 


Console.Write("Введите трёх значное положительное число: ");
int num = Convert.ToInt32(Console.ReadLine());

while (99 >= num || num >= 1000) {
    Console.Write("Не корректный ввод. Введите правильное трёх значное положительное число: ");
    num = Convert.ToInt32(Console.ReadLine());
}

int first_digit = num / 100;
int last_digit = num % 10;
int result = first_digit * 10 + last_digit;
Console.WriteLine(result);