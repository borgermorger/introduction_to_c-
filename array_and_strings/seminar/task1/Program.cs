// Задание №1 

// 1. Задайте массив символов (тип char []). 
// 2. Создайте строку из символов этого массива.

// Указание 
// Конструктор строки вида string(char[]) не использовать 
// char[] chars = new char[] {'a', 'b', 'c', 'd'};
// string str = new string(chars); НЕИСПОЛЬЗОВАТЬ  

// Пример
// ['a', 'b', 'c', 'd'] = > "abcd"

// Функция перевода массива символов в строку
string CharArrToStr(char[] charArr) {
    string result = string.Empty;
    for (int i = 0; i < charArr.Length; i++) {
        result += charArr[i];
    }
    return result;
}

// Вывод массива символов
void PrintCharArr(char[] char_arr){
    for(int i = 0; i < char_arr.Length; i++) {
        Console.Write("[");
        for(i = 0; i < char_arr.Length; i++) {
            if(i == char_arr.Length - 1) {
                Console.Write($"'{char_arr[i]}'");
            }
            else {
                Console.Write($"'{char_arr[i]}', ");
            }
        }
        Console.Write("]");
    }
}

// инициализация массива символов и его вывод
char[] char_array = {'c', 'h', 'a', 'r'};
PrintCharArr(char_array);

// перевод массива символов в строку и его вывод
string result = CharArrToStr(char_array);
Console.WriteLine(result);


// Решение препода
// string CharArrayToString(char[] arr)
// {
//     string res = string.Empty;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         res += arr[i];
//     }
//     return res;
// }

// char[] array = { 'a', 'b', 'c', 'd', 'e', 'f' };
// string result = CharArrayToString(array);
// Console.WriteLine(result);