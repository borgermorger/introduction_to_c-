// Задание №3 

// Заполните массив на N (вводится с консоли, не более 8) случайных целых чисел от 0 до 9.

// Сформируйте целое число, которое будет состоять из цифр из
// массива. Старший разряд числа находится на 0-м индексе,
// младший – на последнем. 

// пример

// [1 3 2 4 2 3] => 132423
// [2 3 1 ] => 231

//Мое решение
// Функция создание массива с рандомными целыми числами
int[] CreatArrayRndInt (int size, int min, int max) {
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

// Функция который создает цифру по требуемому порядку
int ArrayToSpecificInt (int[] array) {
    int maxNum = MaxNumInArray(array);
    int minNum = MinNumInArray(array);
    int result = 0;
    int temp = array[0];
    array[Array.IndexOf(array, maxNum)] = temp;
    array[0] = maxNum;
    array[Array.IndexOf(array, minNum)] = array[array.Length - 1];
    array[array.Length - 1] = minNum;
    for(int i = 0; i < array.Length; i++) {
        result = result * 10 + array[i];
    }
    return result;
}

// Функция для поиска максимального числа в массиве
int MaxNumInArray(int[] array) {
    int max = array[0];
    for (int i = 1; i < array.Length; i++) {
        if (array[i] > max) {
            max = array[i];
        }
    }
    return max;
}

// Функция минимального числа в массиве
int MinNumInArray(int[] array) {
    int min = array[0];
    for (int i = 1; i < array.Length; i++) {
        if (array[i] < min) {
            min = array[i];
        }
    }
    return min;
}

// Пользователь вводит размер массива не больше 8-ми
Console.Write("Введите размер массива не больше 8-им: ");
int size = Convert.ToInt32(Console.ReadLine());

// Проверка вводимого размера массива 
while(size > 8) {
    Console.Write("Некорректный ввод. Введите заново размер не больше 8-ми: ");
    size = Convert.ToInt32(Console.ReadLine());
}

// Создание массива
int[] array = CreatArrayRndInt(size, 0, 9);
// Вывод массива
PrintArray(array);
// Создание переменной результат
int result = ArrayToSpecificInt(array);
// Вывод результата
Console.WriteLine($"Результат: {result}");

//Решение препода
// int[] CreatArrayRndInt(int size, int min, int max)
// {
//     int[] array = new int[size];
//     Random rnd = new Random();
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = rnd.Next(min, max);
//     }

//     return array;
// }

// void PrintArray(int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(i < array.Length - 1)
//         {
//             Console.Write($"{array[i]}, ");
//         }
//         else
//         {
//             Console.Write($"{array[i]}");
//         }
//     }
//     Console.Write("]");
// }

// int ArrayToNumber(int[] array)
// {
//     int res = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         res = res * 10 + array[i];
//     }

//     return res;
// }


// Console.WriteLine("Задайте размер массива: ");
// int n = Convert.ToInt32(Console.ReadLine());

// if ( n < 1 || n > 8)
// {
//     Console.WriteLine("Некорректный ввод!");
//     return; // он выходит из метода main и программа завершает работу
// }

// int[] arr = CreatArrayRndInt(n, 0, 10);
// PrintArray(arr);

// Console.WriteLine($" => {ArrayToNumber(arr)}");