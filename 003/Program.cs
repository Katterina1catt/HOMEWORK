// 3. С клавиатуры вводятся два числа a и b. Найти максимальное из них.

int a,b,max;
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
 if (a>b)
  max=a;
 else
  max=b;
 System.Console.WriteLine($"max={max}");
