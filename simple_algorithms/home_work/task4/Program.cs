// Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.


Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 10) {
    Console.Write(num);
}
else {
    while (num > 0) {
        int current_digit = num % 10;
        num /= 10;
        if (num > 0) {
            Console.Write($"{current_digit}, ");
        }
        else{
            Console.Write(current_digit);
        }
    }
}