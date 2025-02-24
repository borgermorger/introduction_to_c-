// Задача 1: Задайте двумерный массив символов (тип char [,]). 
// Создать строку из символов этого массива.


string Char2DArrToString(char[,] char2DArr) {
    string result = string.Empty;
    foreach(char character in char2DArr) {
        result += character;
    }
    return result;
}

char[,] haikuCharArr = {
    {'S', 'h', 'u', 'k', 'u', 'd', 'a', 'i', ' ', 'o', ' ', 'W', 'a'},
    {'s', 'u', 'r','e','t','e',' ','r','ō','k','a',' ','n'},
    {'i', ' ', 'M','o','g','a','m','i','-','g','a','w','a'}
    };


string result = Char2DArrToString(haikuCharArr);
Console.WriteLine(result);