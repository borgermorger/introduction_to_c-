// Задание №3 

// Задайте двумерный массив из целых чисел. Сформеруйте новый одномерный массив, состоящий из средних арефметических значений 
// по строкам двумерного массива.

// Пример

// 2 3 4 3
// 4 3 4 1   => [3 3 5]
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

// Функцию формирует из средних арефметических значении по строкам таблицы новый одномерный массив 
int[] AverageRowsToArray(int[,] table){
    int[] array = new int[table.GetLength(0)];
    int sum = 0;
    for (int i = 0; i < table.GetLength(0); i++) {
        for (int y = 0; y < table.GetLength(1); y++) {
            sum += table[i, y];
        }
        array[i] = sum / table.GetLength(1);
        sum = 0;
    }
    return array;
}

// Вывод массива на консоль
void PrintArray(int[] array) {
    for (int i = 0; i < array.Length; i++) {
        if (i == array.Length - 1) {
            Console.Write(array[i]);
        }
        else{
            Console.Write($"{array[i]}, ");
        }
    }
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

// Из средней арефметической значений строк таблицы создаем новый массив и выводим на консоль
int[] array = AverageRowsToArray(table);
PrintArray(array);