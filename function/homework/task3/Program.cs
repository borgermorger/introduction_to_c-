// Задача 3: Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)

// Функция создания массива с рандомными цифрами
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
    for (int i = 0; i < array.Length; i++) {
        if (i == array.Length - 1) {
            Console.Write(array[i]);
            Console.WriteLine("");
        }
        else{
            Console.Write($"{array[i]}, ");
        }

    }
}

//
int[] ReverseArrayElem (int[] array) {
    int temp = 0;
    for (int i = 0; i < array.Length / 2; i++) {
        temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
    return array;
}

// Запрос на ввод размера массива у пользователя
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

// Создание массива с размером пользовательского запроса с цифрами от 1 до 10
int[] array = CreatArrayRndInt(size, 1, 11);
PrintArray(array);

// Создаем перевернутый массив и выводим на консоль
int[] reversed_array = ReverseArrayElem(array);
PrintArray(reversed_array);