// Задача 3: Вывод элементов массива в обратном порядке
// Описание: Задайте произвольный массив. Выведите его элементы, начиная с конца.
// Используйте рекурсию и не используйте циклы.
// Пример:
// ● Вход: {1, 2, 3, 4, 5}
// ● Выход: 5, 4, 3, 2, 1
// ● Вход: {10, 20, 30, 40}
// ● Выход: 40, 30, 20, 10

void PrintReversedArrElem(int[] arr, int size) {
    if (size == 0) return;
    Console.Write($"{arr[size - 1]} ");
    PrintReversedArrElem(arr, size - 1);
}

int[] arr = {1, 2, 3, 4, 5};
int size = arr.Length;

PrintReversedArrElem(arr, size);