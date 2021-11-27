// See https://aka.ms/new-console-template for more information
Console.Write("Введите X:  " );
int x =Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y:  " );
int y =Convert.ToInt32(Console.ReadLine());

if (x>0 && y>0)
{
    Console.WriteLine("Координаты в 1 четверти  " );
}
else if (x<0 && y>0)
{
    Console.WriteLine("Координаты во 2 четверти " );
}
else if (x<0 && y<0)
{
    Console.WriteLine("Координаты в 3 четверти  " );
}
else if (x>0 && y<0)
{
    Console.WriteLine("Координаты в 4 четверти  " );
}
else if (x==0 && y==0)
{
    Console.WriteLine("КООРДИНАТЫ РАВНЫ 0  " );
}
else if (x==0 | y==0)
{
    Console.WriteLine("КООРДИНАТЫ ЛЕЖАТ НА ЛИНИИ ФУНКЦИИ, а на какой мне лень писать " );
}