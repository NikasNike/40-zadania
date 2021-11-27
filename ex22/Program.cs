// Проверяет пятизначные числа на палидром
Console.WriteLine("Введите пятизначное число");
int n =Convert.ToInt32(Console.ReadLine());

int digit = 0;  
int digi = 0; 
int di = 0;
int d = 0;
if(n!=0)
{                              
    digit = n%10;  
    digi = n%100 /10;  
    di = n%10000 / 1000;
    d = n / 10000;
}

Console.WriteLine("Result is: " );
if(d==digit && digi==di )
    {
    Console.WriteLine("Palindrome!");
    }
else
{
    Console.WriteLine("Not a Palindrome!");
}
//Console.WriteLine(digit + " " + digi + "  " + di+ "  " + d);
//проверка выполнения действий (пятая цифра, 4 , 2 , 1)