﻿// Задача №2 

// Задайте массив из 10 элементов, заполненный числами из промежутка [-10, 10]. Замените отрицательные элементы на положительные, 
// а положительные на отрицателльные.

// Пример

// [1 -5 6] => [-1 5 -6]

// Создаем объект рандомн
Random rnd = new Random();

// создаем массив и заполняем его рандомными цифрами от -10 до 10
int[] array = new int[10];
for (int i = 0; i < array.Length; i++){
    array[i] = rnd.Next(-10, 11);
}

// выводим массив 
foreach (int e in array) {
    Console.Write($"{e} ");
}
Console.WriteLine("");

// отрицательные элементы меняем на положительные
for (int i = 0; i < array.Length; i++){
    if(array[i] < 0) {
        array[i] = -array[i]; // array[i] *= -1;
    }
}

// выводим измененный массив
foreach (int e in array) {
    Console.Write($"{e} ");
}