// Задание 1: Поиск элемента в массиве
// Описание: Задайте массив целых чисел. Напишите программу, которая проверяет,
// присутствует ли заданное число в массиве. Программа должна вывести:
// Присутствует/Не присутствует.


// Создаем объект рандомн
Random rnd = new Random();

// создаем массив и заполняем его рандомными цифрами от -100 до 100
Console.WriteLine("Создается массив в десять целых чисел от -100 до 101");
int[] array = new int[10];
for (int i = 0; i < array.Length; i++){
    array[i] = rnd.Next(-100, 101);
}

// выводим массив 
foreach (int e in array) {
    Console.Write($"{e} ");
}
Console.WriteLine("");

// вводим цифру для поиска в массиве
Console.Write("Введите целое число для поиска в массиве: ");
int num = Convert.ToInt32(Console.ReadLine());

// создаем цикл для поиска этой цифры в массиве
bool isInArray = false;
foreach (int e in array) {
    if (e == num) {
        isInArray = true;
    }
}

// выводим резуельтат
Console.WriteLine("Присутствует ли введенное цифра в массиве?");
Console.WriteLine(isInArray ? "Присутствует" : "Не присутствует");