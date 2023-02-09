// 5. С клавиатуры вводятся три числа. Найти максимальное из трех чисел

int a,b,c,max;
a = Convert.ToInt32(Console.ReadLine());
max = a;
b = Convert.ToInt32(Console.ReadLine());
c = Convert.ToInt32(Console.ReadLine());
 if (a>b) 
 if (a>c)
 max=a;
 else if (a>b)
 if (a<c)
 max=c;
 else if (a<b)
 if (b>c)
 max=b;
else if (a<b)
if (b<c)
 {
 max=c;
 }

 System.Console.WriteLine($"max={max}");
