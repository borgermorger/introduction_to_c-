// Задание №1 

// Задайте двумерный массив. Найдите элеметы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

// Пример
// 0  1  2   3

// 2 3 4 3       0   4  3  16  3
// 4 3 4 1    => 1   4  3  4   1
// 2 9 5 4       2   4  9  25  4

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

// Функция, которая возводит в квадрат элементы, у которых оба индекса четные
int[,] SquareEvenIndexElements(int[,] table) {
    for (int i = 0; i < table.GetLength(0); i++) {
        for (int y = 0; y < table.GetLength(1); y++) {
            if (i % 2 == 0 && y % 2 == 0) {
                table[i, y] *= table[i, y];
            }
        }
    }
    return table;
}

// Запрос у пользователя количество строк в таблице
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
// Запрос у пользователя количество столбцев в таблице
Console.Write("Введите количество столбцев: ");
int columns = Convert.ToInt32(Console.ReadLine());

// Создание таблицы и его вывод
int[,] table = CreateTable(rows, columns);
PrintTable(table);

// Разделение двух таблицы отступом
Console.WriteLine();

// Создание и вывод новой таблицы у которой возведены в квадрат элементы, индексы которых четны
int[,] new_table = SquareEvenIndexElements(table);
PrintTable(new_table);