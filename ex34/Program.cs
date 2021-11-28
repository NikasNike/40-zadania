// Массив из 12 чисел заполненый 0 и 9. Найти сумму положительных и отрицательных элементов.
int [] a =new int[12];
Random rnd = new Random();
int y = 0;
int r  =0;
for(int i =0;i<12;++i)
{
    a[i] = rnd.Next(-9, 10);
    if (a[i]>0 )
    {
        y=a[i] + y;
        Console.WriteLine(" проверка.   сумма четных = " + y + " число = " + a[i] + " значение i = " + i + " сумма отриц =  "  +r );
    }
    else
    {
        r=a[i] + r;
    }
}
Console.WriteLine("Сумма положительных чисел: "+y);
Console.WriteLine("Сумма отрицательных чисел: " + r);