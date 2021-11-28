// Программа вычисления произведения чисел от 1 до N
Console.WriteLine("Введите число:");
int y = Convert.ToInt32(Console.ReadLine());
//int N = 15;              //если >15 то переполнение в int
ulong F=1;//тип лонг он 64бит и вычисляет больше занчений  (ulong)-только положительные
for(int N=1;N<=y;N++){   //если 1 действие можно писать так
    F=1;
for(int i = 1; i<=N; i++)
{
   F=F*(uint)i;   // привели i к (uint)
}
Console.WriteLine("N = "+N+"  F= " +F);
}

     


