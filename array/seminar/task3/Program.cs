// Задача №3
// Найдите произведения пар чисел в одномерном массиве парой считаем первый и последний элемент, второй и 
// предпоследний и т.д. результат запишите в новый массив. 

// пример 
// [1 3 2 4 2 3] => [3 6 8]
// [2 3 1 7 5 6 3] => [6 18 5] (Элемент 7 не имеет пары) 

// Создаем объект рандомн
Random rnd = new Random();

// создаем массив и заполняем его рандомными цифрами от 1 до 9
int[] array = new int[5];
for (int i = 0; i < array.Length; i++){
    array[i] = rnd.Next(1, 10);
}

// выводим массив 
foreach (int e in array) {
    Console.Write($"{e} ");
}
Console.WriteLine("");

int array_length_half = array.Length / 2;
int[] new_array = new int[array_length_half];
for (int i = 0; i < array_length_half; i++) {
    new_array[i] = array[i] * array[^(i + 1)];
}

// выводим массив новый массив 
foreach (int e in new_array) {
    Console.Write($"{e} ");
}

if (array.Length % 2 != 0){
    Console.WriteLine($"число {array[array.Length / 2 + 1]} не имеет пары");
}