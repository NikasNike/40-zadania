//По двум числам проверять является ли одно число квадратом певромго
Console.Write ("Введите число: " ); 
double a = Convert.ToDouble(Console.ReadLine());

Console.Write ("Введите второе число: ");
double b = Convert.ToDouble(Console.ReadLine());

double c = a*a;

if (c==b)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}
return;



