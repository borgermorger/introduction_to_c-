// Считать строку с консоли, содержащую латниские буквы. Вывести на экран согласные буквы этой строки.

// Указание
// Использовать рекурсию. Не использовать цикл

// Пример
// "hello" => h l l 
// "World" => W r l d 
// "Hello world" = > H l l w r l d 

void PrintCons(string str, int index = 0) {
    if (index == str.Length) {
        return;
    }
    string vowels = "EYUIOAeyuioa";
    if (char.IsAsciiLetter(str[index]) && !vowels.Contains(str[index])) {
        Console.Write(str[index]);
    }

    PrintCons(str, index + 1);
}

Console.WriteLine("Введите строку содержащую латинские буквы: ");
string input = Console.ReadLine();

PrintCons(input);