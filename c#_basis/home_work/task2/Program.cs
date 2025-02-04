// Задание 2
// Поиск среднего из трех чисел
// Описание: Напишите метод, который принимает на вход три числа и возвращает
// среднее из этих чисел (то есть не самое большое и не самое маленькое).
// Пример использования: На входе:
// ● a: 5
// ● b: 3
// ● c: 8
// На выходе:
// ● 5
// На входе:
// ● a: 1
// ● b: 9
// ● c: 7
// На выходе:
// ● 7


Console.Write("Введите первое целое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье целое число: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a <= b && b <= c || c <= b && b <= a) {
    Console.WriteLine(b);
}
if (b <= a && a <= c || c <= a && a <= b) {
    Console.WriteLine(a);
}
if (b <= c && c <= a || a <= c && c <= b) {
    Console.WriteLine(c);
}