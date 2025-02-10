// Задание №2 

// Задайте двумерный массив. Найдите сумму элементов, находяшихся на главной диагонали (с индексами (0,0);(1,1) и т.д.)

// пример

// 2 3 4 3 
// 4 3 4 1   =>   2 + 3 + 5 = 10
// 2 9 5 4 


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

// Функция по суммированию элементов таблицы, которые находтся на главном диагонале
int SumMainDiagonal(int[,] table) {
    int sum = 0;
    for (int i = 0; i < table.GetLength(0); i++) {
        for (int y = 0; y < table.GetLength(1); y++) {
            if (i == y) {
                sum += table[i, y];
            }
        }
    }
    return sum;
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

int result = SumMainDiagonal(table);
Console.WriteLine($"Сумма элементов, которые находтся на главной диагонале: {result}");