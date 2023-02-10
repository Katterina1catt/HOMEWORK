// 22. По двум заданным числам проверять является ли одно квадратом другого.

int a,b;
a=Convert.ToInt32(Console.ReadLine());
b=Convert.ToInt32(Console.ReadLine());
if (a*a==b)
 System.Console.WriteLine("b является квадратом a");
    if (b*b==a)
    System.Console.WriteLine("a является квадратом b");
else 
 System.Console.WriteLine("Ни одно из чисел не равняется квадратом другого");

//  if (a*a==b || b*b==a)
//         System.Console.WriteLine("Является");
// else 
//  System.Console.WriteLine("Ни одно из чисел не равняется квадратом другого");