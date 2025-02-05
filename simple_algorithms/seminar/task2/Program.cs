// Напишите программу, которая приимает на вход трёхзначное число и возводит вторую цифру этого ичлса в степень, равную третьеё цифре

// Примеры 

// 487 => 8^7 = 2 097 152
// 254 => 5^4 = 625
// 617 => 1

Console.Write("Введите трёх значное положительное число: ");
int num = Convert.ToInt32(Console.ReadLine());

while (99 >= num || num >= 1000) {
    Console.Write("Не корректный ввод. Введите правильное трёх значное положительное число: ");
    num = Convert.ToInt32(Console.ReadLine());
}

int last_digit = num % 10;
int middle_digit = num / 10 % 10;

int result = 1;
for (int i = 0; i < last_digit; i++) {
    result *= middle_digit;
}

Console.Write(result);