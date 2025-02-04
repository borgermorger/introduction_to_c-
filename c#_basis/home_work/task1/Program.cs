// Задание 1
// Определите, делится ли число на другое
// Описание: Напишите метод, который на вход принимает два целых числа и проверяет,
// делится ли первое число на второе. Если делится, выводите "делится", иначе
// выводите "не делится".
// Пример использования: На входе:
// ● firstNumber: 10
// ● secondNumber: 2
// На выходе:
// ● делится
// На входе:
// ● firstNumber: 10
// ● secondNumber: 3
// На выходе:
// ● не делится



Console.Write("Введите первое целое число: ");
int first_num = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int second_num = Convert.ToInt32(Console.ReadLine());

if (second_num == 0) {
    Console.WriteLine("На ноль делить нельзя");
}
else if (first_num % second_num == 0) {
    Console.WriteLine("делится");
}
else {
    Console.WriteLine("не делится");
}