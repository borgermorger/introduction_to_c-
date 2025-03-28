// задание 1

// Задайте значение N. Напишите программу, которая выведет все натуральные  числа в промежутке от 1 до N. 

// Указание 
// Использовать рекурсию. Не использовать цикл.

// Пример
// N = 5 => 1 2 3 4 5

void PrintNaturalNumRecursion(int n) {
    if(n == 0) {
        return;
    }
    PrintNaturalNumRecursion(n - 1);
    Console.Write($"{n} ");
}

Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
PrintNaturalNumRecursion(num);