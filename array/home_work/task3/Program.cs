// Задание 3: Поиск среднего значения массива
// Описание: Задайте массив из 10 целых чисел. Найдите среднее значение элементов
// массива.

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

double sum = 0;
double average = 0;
foreach (int e in array) {
    sum += e;
    average = sum / array.Length;
}

Console.WriteLine($"Среднее значение цифр массива равна: {average}");