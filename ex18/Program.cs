// 17. По двум заданным числам проверять является ли одно квадратом другого



Console.WriteLine ("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine ());
Console.WriteLine ("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine ());
if (Math.Pow(b,2) == a || Math.Pow(a,2) == b) Console.WriteLine ("Да одно число квадрат второго");
else 
{
    Console.WriteLine ("числа не являются квадратами друг друга");
}