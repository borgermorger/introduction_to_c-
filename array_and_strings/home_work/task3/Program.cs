// Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.

bool IsPolindrom(string text) {
    bool res = true;
    for(int i = 0; i < text.Length / 2; i++) {
        if (text[i] == text[text.Length - i - 1]) {
        }
        else{
            res = false;
            break;
        }
    }
    return res;
}

Console.Write("Введите строку: ");
string text = Console.ReadLine();

if(IsPolindrom(text)){
    Console.Write("Yaappiii is polindom");
}
else{
    Console.Write("Ohh no it aint polindrom");
}