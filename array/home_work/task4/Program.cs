// Задание 4: Удаление всех отрицательных чисел
// Описание: Задайте массив целых чисел. Напишите программу, которая удаляет все
// отрицательные числа из массива и возвращает новый массив, содержащий только
// неотрицательные числа.

// Моё решение
// Создаем объект рандомн
Random rnd = new Random();

// создаем массив и заполняем его рандомными цифрами от -10 до 10
Console.WriteLine("Создается массив в десять целых чисел от -10 до 11");
int[] array = new int[10];
for (int i = 0; i < array.Length; i++){
    array[i] = rnd.Next(-10, 11);
}

// выводим массив 
foreach (int e in array) {
    Console.Write($"{e} ");
}
Console.WriteLine("");

int countMinusElemnts = 0;
foreach (int e in array) {
    if (e < 0) {
        countMinusElemnts ++;
    }
}

int[] array_without_minus_elem = new int[array.Length - countMinusElemnts];
int count = 0;
for (int i = 0; i < array.Length; i++){
    if (array[i] >= 0) {
        array_without_minus_elem[count] = array[i];
        count ++;
    }
}

// выводим массив 
foreach (int e in array_without_minus_elem) {
    Console.Write($"{e} ");
}
Console.WriteLine("");

// // Эталонное решение

// // Создаем объект рандомн
// Random rnd = new Random();

// // создаем массив и заполняем его рандомными цифрами от -10 до 10
// Console.WriteLine("Создается массив в десять целых чисел от -10 до 11");
// int[] array = new int[10];
// for (int i = 0; i < array.Length; i++){
//     array[i] = rnd.Next(-10, 11);
// }

// // выводим массив 
// foreach (int e in array) {
//     Console.Write($"{e} ");
// }
// Console.WriteLine("");

// // Метод Where фильтрует элементы массива, оставляя только те, которые соответствуют условию. (n => n >= 0) - это лямбда-выражение, 
// // где n представляет каждое число в массиве array
// // ToArray(): Этот метод преобразует результат фильтрации (коллекцию чисел) обратно в массив.
// int[] result = array.Where(n => n >= 0).ToArray();

// // выводим массив 
// foreach (int e in result) {
//     Console.Write($"{e} ");
// }
// Console.WriteLine("");