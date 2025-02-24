// Задание 2

// На основе символов сторки (тип string) сформировать массив символов (тип char []). Вывести массив на экран.

// Указание 
// Метод строки ToCharArray() не использовать 
// string str = "Hello";
// char[] characters = str.ToCharArray();

// Пример
// "Helllo!" => ["H", "e", "l", "l", "0", "!" ]

// функция перевода строки в массив символов
char[] StrToCharArr(string str){
    char[] charResult = new char[str.Length];
    for (int i = 0; i < str.Length; i++) {
        charResult[i] = str[i];
    }
    return charResult;
}

// функция вывод массива символов
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

// инициализация строки и его вывод
string str = "Hello!";
Console.WriteLine(str);

// перевод строки в массив символов и его вывод
char[] result = StrToCharArr(str);
PrintCharArr(result);