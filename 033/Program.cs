// 33. Возведите число А в натуральную степень B используя цикл

double a,b;
a=Convert.ToInt32(Console.ReadLine());
b=Convert.ToInt32(Console.ReadLine());
if (b>0) 
    {
        a=Math.Pow(a,b);
        System.Console.WriteLine(a);
    }