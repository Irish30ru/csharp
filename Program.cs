// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите первое значение: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе  значение: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье значение: ");
int c= Convert.ToInt32(Console.ReadLine());

if (a>b && a>c)
    Console.Write($"Максимальное значение: {a}");
if (b>a && b>c)
    Console.Write($"Максимальное значение: {b}");
if (c>a && c>b)
    Console.Write($"Максимальное значение: {c}");