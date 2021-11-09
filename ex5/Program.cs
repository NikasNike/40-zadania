// Максимальное из 3
Console.Write ("Введите число: " ); 
double a = Convert.ToDouble(Console.ReadLine());

Console.Write ("Введите второе число: ");
double b = Convert.ToDouble(Console.ReadLine());

Console.Write ("Введите третье число: ");
double c = Convert.ToDouble(Console.ReadLine());
double max = a;


if (max<b) max = b;
if (c>max) max = c;
Console.Write (max);

