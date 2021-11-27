// See https://aka.ms/new-console-template for more information
Console.Write("Введите номер четверти:  " );
int n =Convert.ToInt32(Console.ReadLine());
if(n==1)
{
    Console.Write("Диапазон: x(0;+∞) , y(0;+∞)  " );
}
if(n==2)
{
    Console.Write("Диапазон: x(-∞;0) , y(0;+∞)  " );
}
if(n==3)
{
    Console.Write("Диапазон: x(-∞;0) , y(-∞;0)  " );
}
if(n==4)
{
    Console.Write("Диапазон: x(0;+∞) , y(-∞;0)  " );
}
//Console.WriteLine( (Double.PositiveInfinity + 10.0).ToString()); писать про знак бесконечности но я хз как