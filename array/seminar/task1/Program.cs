// задача №1
// задайте массив. Напишите программу, которая определяет присутствует ли заданное число в массиве. Программа должна выдать ответ: Да/нет.

// Примеры 
// [1 3 4 19 3], 8 => нет
// [-4 3 4 1], 3 => ДА


// вводим размер массива
Console.Write("Задайте размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

// создание массива 
int[] array = new int[size];

// заполнение массива
for (int i = 0; i < size; i++) {
    Console.Write($"Введите {i + 1} число массива: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

// вводим число для поиска
Console.Write("Введите число для поиска: ");
int num = Convert.ToInt32(Console.ReadLine());

bool isNumInArrey = false;
foreach(int e in array) {
    if (num == e) {
        isNumInArrey = true;
    }
}

if (isNumInArrey) {
    Console.Write($"цифра {num} есть в массиве");
}
else {
    Console.Write($"цифры {num} нету в массиве");
}

// Можно написать более изящний вариант как внизу
//Console.WriteLine(isNumInArrey ? $"цифра {num} есть в массиве" : $"цифры {num} нету в массиве");