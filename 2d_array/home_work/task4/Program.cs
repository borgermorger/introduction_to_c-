// Задание 4: Замена отрицательных элементов в двумерном массиве
// Описание: Задайте двумерный массив. Замените все отрицательные числа на их
// абсолютные значения.
// Пример входных данных:
// 1 -2 3
// -4 5 -6
// 7 -8 9
// Пример результата:
// 1 2 3
// 4 5 6
// 7 8 9

// Функция создание таблицы
int[,] CreateTable(int rows, int columns) {
    Random rnd = new Random();
    int[,] table = new int[rows, columns];
    for (int i = 0; i < rows; i++) {
        for (int y = 0; y < columns; y++) {
            table[i, y] = rnd.Next(-10, 10);
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

int[,] AbsoluteTableValue(int[,] table) {
    for (int i = 0; i < table.GetLength(0); i++) {
        for (int y = 0; y < table.GetLength(1); y++) {
            if (table[i, y] < 0) {
                table[i, y] *= -1;
            }
        }
    }
    return table;
}

// Создание массива и его вывод
int[,] table = CreateTable(4, 3);
PrintTable(table);
Console.WriteLine();

int[,] absoluteTable = AbsoluteTableValue(table);
PrintTable(absoluteTable);