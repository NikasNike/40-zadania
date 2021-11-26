// Дано число. Проверить кратно ли оно 7 и 23.
int number;

Console.Write("Введите число : ");
number=Convert.ToInt32(Console.ReadLine());

if (number % 7 == 0)
{
    Console.WriteLine($"Число: ::{number}:: КРАТНО 7 и НЕ КРАТНО 23");    
}
if (number % 23 == 0)
{
    Console.WriteLine($"Число: ::{number}:: КРАТНО 23 и НЕ КРАТНО 7");
}
if (number % 7 != 0 && number % 23 != 0)
{
    Console.WriteLine($"Число: ::{number}:: НЕ КРАТНО 7 И НЕ КРАТНО 23");
}
