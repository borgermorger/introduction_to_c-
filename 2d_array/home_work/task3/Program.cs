// Задание 3: Транспонирование двумерного массива
// Описание: Задайте двумерный массив целых чисел. Напишите программу, которая
// транспонирует массив (меняет строки и столбцы местами).
// Пример входных данных:
// 1 2
// 3 4
// 5 6
// Пример результата:
// 1 3 5
// 2 4 6

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

int[,] TranspositionTableElem(int[,] table) {
    int[,] transTable = new int[table.GetLength(1), table.GetLength(0)];
    for (int i = 0; i < table.GetLength(0); i++) {
        for (int y = 0; y < table.GetLength(1); y++) {
            transTable[y,i] = table[i,y];
        }
    }
    return transTable;
}

// Создание массива и его вывод
int[,] table = CreateTable(4, 3);
PrintTable(table);
Console.WriteLine();

// Транспонирование таблицы и его вывод
int[,] transTable = TranspositionTableElem(table);
PrintTable(transTable);