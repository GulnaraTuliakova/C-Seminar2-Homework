//По двум заданным числам проверять является ли одно квадратом другого
Console.WriteLine("По двум числам проверим, является ли одно квадратом другого.");
Console.WriteLine("Введите первое число:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int b = int.Parse(Console.ReadLine());
if (a==b*b)
Console.WriteLine($"Число {a} является квадратoм числа {b}");
else if (b==a*a)
Console.WriteLine($"Число {b} является квадратoм числа {a}");
else
Console.WriteLine($"Числа {a} и {b} не являются квадратом друг друга"); 