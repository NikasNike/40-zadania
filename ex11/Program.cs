Random  ran = new Random();
int number;
number = ran.Next(100,1000);
Console.WriteLine(number);

string str = Convert.ToString(number);

char[] mas = str.ToCharArray();
Console.WriteLine(ran);
Console.WriteLine("вторая цифра " +mas[1]);
