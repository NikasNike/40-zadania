//Числа от 10 до 99. Показать НАИБОЛЬШУЮ ЦИФРУ ЧИСЛА
int a  =new Random().Next(10, 99);
Console.WriteLine("Случайное число: "+ a);

int b = a/10 ;
int i = a%10 ;
if(i>b)
{
    Console.WriteLine("Большее число: " + i );

}
else
{
    Console.WriteLine("Большее число: "+ b );    
}