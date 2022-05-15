// Найти расстояние между точками в пространстве 2D/3D
Console.WriteLine("Найдем расстояние между двумя точками в 2D или 3D пространстве. Для 2D пространства z укажите равным 0.");
Console.ReadLine();
Console.WriteLine("Введите координаты x1 первого числа: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты у1 первого числа: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты z1 первого числа: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты x2 второго числа: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты у2 второго числа: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты z2 второго числа: ");
double z2 = Convert.ToDouble(Console.ReadLine());
double result = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));
        //double result = Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2)+Math.Pow((z2-z1),2));
Console.WriteLine($"Расстояние между двумя точками равно {result}");
Console.ReadLine();
