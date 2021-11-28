// Массив из 8 чисел заполненый 1 и 0
int [] a =new int[8];
Random rnd = new Random();
for(int i =0;i<8;++i)
{
    a[i] = rnd.Next(0, 2);
    Console.WriteLine(a[i]+ " ");
}

