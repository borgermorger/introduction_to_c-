// Задание 3

// Считать сторку с консоли, состоящую из латинских букв в нижнем 
// регистре. Выяснить, сколько среди введённых букв гласных.

// Пример

// "Hello" => 2
// "world" => 1

int CountLowerCaseVowels(string text) {
    string lowerCaseVowels = "eyuioa";
    int count = 0;
    foreach(char e in text) {
        foreach(char i in lowerCaseVowels) {
            if (e == i) {
                count +=1;
            }
        }
    }
    return count; 
}

string str = "Hello world!";
int result = CountLowerCaseVowels(str);
Console.WriteLine($"В тексте: '{str}' - {result} маленьких гласных латинских букв.");
