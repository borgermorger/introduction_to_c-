// Задание 1: Поиск максимального элемента в каждой строке
// Описание: Задайте двумерный массив целых чисел. Напишите программу, которая
// находит максимальный элемент в каждой строке массива и выводит его.
// Пример входных данных:
// 1 3 5 7
// 2 4 6 8
// 9 10 11 12
// Пример результата:
// Максимальный элемент в строке 0: 7
// Максимальный элемент в строке 1: 8
// Максимальный элемент в строке 2: 12


// Функция создание таблицы
int[,] CreateTable(int rows, int columns) {
    Random rnd = new Random();
    int[,] table = new int[rows, columns];
    for (int i = 0; i < rows; i++) {
        for (int y = 0; y < columns; y++) {
            table[i, y] = rnd.Next(1, 10);
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

// Функция по выводу максимального элемента в каждой строке двумерного массива
void PrintLineMaxElem(int[,] table) {
    int max = 0;
    for (int i = 0; i < table.GetLength(0); i++) {
        for (int y = 0; y < table.GetLength(1); y++) {
            if (table[i, y] > max) {
                max = table[i, y];
            }
        }
        Console.WriteLine($"Максимальный элемент в строке {i}: {max}");
        max = 0;
    }
}

// Создание массива и его вывод
int[,] table = CreateTable(3, 4);
PrintTable(table);
// Отступ
Console.WriteLine();

// Вывод максимального элемента в каждой строке двумерного массива
PrintLineMaxElem(table);