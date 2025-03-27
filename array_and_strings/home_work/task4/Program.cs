// Задача 4*(не обязательная): Задайте строку, состоящую из слов, разделенных пробелами. 
// Сформировать строку, в которой слова расположены в обратном порядке. В полученной строке 
// слова должны быть также разделены пробелами.

string ReversWords(string text){
    string[] words = text.Split(" ");
    Array.Reverse(words);
    return string.Join(" ",words);
}

Console.Write("Введите строку: ");
string text = Console.ReadLine();

Console.WriteLine(ReversWords(text));