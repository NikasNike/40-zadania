// показать числа от N до N

void met (int N)
{
    int count = -N;
    while (count<=N)
    {
        Console.WriteLine(count);
        count++;
    }
}
met(12);
