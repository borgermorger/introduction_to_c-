// Задайте массив из N случайных чисел (N ввыодится с клавиатуры).

// Найдите количество чисел, которые заканчиваются на 1 и делятся нацело на 7. 

// Пример

// [1 5 11 21 81 4 0 91 2 3] => 2

// Функция создание массива с рандомными целыми числами
int[] CreatMatrixRndInt (int size, int min, int max) {
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++) {
        array[i] = rnd.Next(min, max);
    }
    return array;
}

// Функция вывода массива на консоль
void PrintArray (int[] array) {
    foreach (int e in array) {
        if (e == array[array.Length -1]) {
            Console.Write(e);
            Console.WriteLine("");
        }
        else{
            Console.Write($"{e}, ");
        }

    }
}

int CountSpecificNums (int[] array, int lastNum, int dev) {
    int count = 0;
    for (int i = 0; i < array.Length; i++) {
        if (array[i] % 10 == lastNum && array[i] % dev == 0) {
            count++;
        }
    }
    return count;
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = CreatMatrixRndInt(size, 1, 100);
PrintArray(array);
int result = CountSpecificNums(array, 1, 7);
Console.WriteLine($"В массива {result} цифр которые оканчиваются на 1 и деляться на 7");