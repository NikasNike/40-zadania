// удалить вторую цифру трех значного числа

string Delete2Number (int n)
{

    return $"{n/100}-{n%10}";
    //return 10*(n)/100+n%10; проверить 
    //Matn.Abs (number)' // модуль числа
}
Console.WriteLine("Введите трехзначное число: ");
int a=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Способ №3  " +Delete2Number(a));//пишется -






//Удалить вторую цифру трёхзначного числа ДРПУГИЕ СПОСОБЫ

Console.WriteLine("Введите техзначное число");//если число 123
int b, c, t;
t = Convert.ToInt32(Console.ReadLine());
c = t - t % 100 + t % 10;//t%100 = 23 t % 10 =3
Console.WriteLine("Способ №1  "+ c);//пишется 0
b = t / 100 * 10 + t % 10;
Console.WriteLine("Способ №2  " + b);//удаляется полностью