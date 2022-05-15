//Задать номер четверти, показать диапазоны для возможных координат
Console.WriteLine("Чтобы увидеть диапазоны координат x и y, введите номер четверти координатной плоскости от 1 до 4:");
int a = int.Parse(Console.ReadLine());
if (a==1)
Console.WriteLine($"В {a} четверти координаты х > 0,  у > 0");
else if (a==2)
Console.WriteLine($"В {a} четверти координаты х < 0, у > 0");
else if (a==3)
Console.WriteLine($"В {a} четверти координаты х < 0,  у < 0");
else if (a==4)
Console.WriteLine($"В {a} четверти координаты х > 0, у < 0");
else
Console.WriteLine("Вы ввели неверное число"); 