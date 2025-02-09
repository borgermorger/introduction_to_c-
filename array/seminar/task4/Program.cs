// Задание 4

// Дано натуральное треёхзначное число. Создайте массив, состоящий из цифр этого числа. Младщий разряд числа должен 
// распологаться на 0-ом индексе массиа, старший на 2-ом индексе.

// Пример 

// 456 => [6 5 4]
// 781 => [1 8 7]


Console.Write("Введите трёхзначное целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

int[] array = {num / 100, num / 10 % 10, num % 10};

int max = array[0];
int middle = array[0];
int min = array[0];
foreach (int e in array) {
    if (e > max) {
        middle = max;
        max = e;
        continue;
    }
    if (e < min) {
        middle = min;
        min = e;
    }
}

int[] new_array = {min, middle, max};

// выводим массив 
foreach (int e in new_array) {
    Console.Write($"{e} ");
}
Console.WriteLine("");