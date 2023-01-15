Console.Write("Введите первое значение: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе значение: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a>b)
    Console.Write($"Максимальное значение: {a}");
else
    Console.Write($"Максимальное значение: {b}");