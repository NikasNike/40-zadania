// Сумма чисел от 1 до A
Console.WriteLine("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());
int i = 1;
int y = 1;

for(int o = 0;o<n;o++)
{
    
    i = y+i;
    //Console.WriteLine(o  +"  действие = " + i);      проверка
    y = ++y;
    
}
 Console.WriteLine("Сумма чисел от 1 до " + n + " = " + i);