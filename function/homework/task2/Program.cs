// Задача 2: Задайте массив заполненный случайными трёхзначными числами. Напишите программу, которая покажет 
// количество чётных чисел в массиве.

// Мое решение
// Функция создание массива с рандомными цифрами
int[] CreatArrayRndInt (int size, int min, int max) {
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++) {
        array[i] = rnd.Next(min, max);
    }
    return array;
}

// Функция вывода элементов массива на консоль
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

// Функция подчета четных элементов в массиве 
int CountEvenElem(int[] array) {
    int count = 0;
    foreach(int e in array) {
        if (e % 2 == 0) {
            count ++;
        }
    }
    return count;
}

// Запрос на ввод размера массива у пользователя
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

// Создание массива с размером пользовательского запроса с трехзначными цифрами
int[] array = CreatArrayRndInt(size, 100, 1000);
PrintArray(array);

// Считаем сколько четных цифр в массиве и выводим на консоль
int result = CountEvenElem(array);
Console.WriteLine($"В массивае {result} четных чисел");