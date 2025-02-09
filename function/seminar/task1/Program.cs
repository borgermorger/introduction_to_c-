// Задача №1

// Задайте одномерный массив, заполненный случайными числами. Определите количество простых чисел в этом массиве.

// Примеры 

// [1 3 4 19 3] => 2
// [4 3 4 1 9 5 21 13] => 3

// Функция создание массива с рандомными целыми числами
int[] CreatMatrixWithRandNumbs (int size, int min, int max) {
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

// Функция счета простых чисел в массиве
int CountPrimeNumInArray (int[] array) {
    int count = 0;
    for (int i = 0; i < array.Length; i++) {
        if (IsPrime(array[i])){
            count++;
        }
    }
    return count;
}

// функция проверки числа на простату)))
bool IsPrime(int num){
    bool itIs = true;
    for (int i = 2; i < num; i ++) {
        if (num % i == 0) {
            itIs = false;
            break;
        }
    }
    return itIs;
}

// использовании функции в программе
int[] array = CreatMatrixWithRandNumbs(10, 1, 100);
PrintArray(array);
// заносим количество простых чисел в результат 
int result = CountPrimeNumInArray(array);

// Вывод результата
Console.WriteLine($"В массиве {result} простых чисел");