// Задание 2: Поиск суммы элементов в каждом столбце
// Описание: Задайте двумерный массив целых чисел. Напишите программу, которая
// находит сумму элементов в каждом столбце массива и выводит её.
// Пример входных данных:
// 1 2 3
// 4 5 6
// 7 8 9
// 10 11 12
// Пример результата:
// Сумма элементов в столбце 0: 22
// Сумма элементов в столбце 1: 26
// Сумма элементов в столбце 2: 30

// Функция создание таблицы
int[,] CreateTable(int rows, int columns) {
    Random rnd = new Random();
    int[,] table = new int[rows, columns];
    for (int i = 0; i < rows; i++) {
        for (int y = 0; y < columns; y++) {
            table[i, y] = rnd.Next(1, 20);
        }
    }
    return table;
}

// Функция вывода таблицы
void PrintTable(int[,] table) {
    for (int i = 0; i < table.GetLength(0); i++) {
        for (int y = 0; y < table.GetLength(1); y++) {
            if (y == table.GetLength(1) -1) {
                Console.Write(table[i, y]);
            }
            else {
                Console.Write($"{table[i, y]}, ");
            }
        }
        Console.WriteLine("");
    }
}

// Вывод сумм строк двумерного массива

void PrintLineSum(int[,] table) {
    int sum = 0;
    for (int i = 0; i < table.GetLength(0); i++) {
        for (int y = 0; y < table.GetLength(1); y++) {
            sum += table[i, y];
        }
        Console.WriteLine($"Сумма элементов в столбце {i}: {sum}");
        sum = 0;
    }
}
// Создание массива и его вывод
int[,] table = CreateTable(4, 3);
PrintTable(table);
Console.WriteLine();
// Вывод суммы строк двумерного массива
PrintLineSum(table);