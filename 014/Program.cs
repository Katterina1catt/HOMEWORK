// 14. С клавиатуры вводятся два числа a и b. Выяснить, кратно ли число a числу b, если нет, вывести остаток от деления a на b.

int a,b,i;
a=Convert.ToInt32(Console.ReadLine());
b=Convert.ToInt32(Console.ReadLine());
if (a%b==0)
{
    System.Console.WriteLine("Число a кратно числу b");
}
else
{
    i=a%b;
    System.Console.WriteLine($"Остаток: {i}");
}

