// 14. Найти третью цифру числа или сообщить, что её нет(от 10 до 10000)
int a=new Random().Next(10,10000);//число создается рандомно
Console.WriteLine("Число: " + a);
if(a>100)
{
    if(a>1000)
    {
        a = a % 100/10;
    }
    else
    {
        a = a % 10;
    }
    Console.WriteLine("Третья цифра: " + a);
}   
else
{
    Console.WriteLine("Нету третьей цифры:(");
}
