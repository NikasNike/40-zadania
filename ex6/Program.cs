// значение функции y=f(a)
// 5. Написать программу вычисления значения функции y=f(a)
Console.WriteLine("Введите целое число ");
int k = Convert.ToInt32(Console.ReadLine());

int io(int a)
{
    int y;
    y = a + 2*a;
    return y;
}

Console.WriteLine("значение фукции " +io(k));
