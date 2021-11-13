//расчет кошелька, прибыли
//w= Расклад; a = Начальная сумма  ; c= финальная сумма ; h= дни; b= процент в день
//max = a; sol - считает сколько раз вывел; d- 1 действие; e = второе дейсвие; t = выражение за 1 день
//
//
Console.WriteLine ("Расчитать проценты: 1 " ); 
Console.WriteLine ("Расчитать дни: 2 " ); 
Console.Write ("Введите значение:  " ); 
double w = Convert.ToDouble(Console.ReadLine());
{
    if(w==1)
    {
        Console.Write ("Начальная сумма: " ); 
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write ("Какую сумму надо: " ); 
        double c = Convert.ToDouble(Console.ReadLine());
        Console.Write ("За сколько дней: " ); 
        double h = Convert.ToDouble(Console.ReadLine());
        double max = a; 
        int sol = 0;
        {


            while  (max < c) 
            {
                //4444444444
    //22222222222222222
//1111111111111
  //      555555555555555555555
             
                sol = sol +  1;

            }
            Console.WriteLine("  ");
            Console.WriteLine("  ");
            Console.WriteLine("проценты");
            return;
        }



    }
    else
    {
        Console.Write ("Начальная сумма: " ); 
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write ("Какую сумму надо: " ); 
        double c = Convert.ToDouble(Console.ReadLine());
        
        Console.Write ("процент в день: " ); 
        double b = Convert.ToDouble(Console.ReadLine());


        double max = a; 
        int sol = 0;

        {


            while  (max < c) 
            {
                double d = (max/100);

                double e = (d*b);
                double t = (e+max);
                max = t;
    

        
             Console.WriteLine(t);
                sol = sol +  1;

            }
            Console.WriteLine("  ");
            Console.WriteLine("  ");
            Console.WriteLine("дни: "  + sol);
            return;
        }
    }
}