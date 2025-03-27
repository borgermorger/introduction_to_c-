// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку, 
// в которой все заглавные буквы заменены на строчные.


Console.Write("Введите строку: ");
string text = Console.ReadLine();
string res = text.ToLower();
Console.WriteLine(res);