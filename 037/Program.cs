// 37. Компьютер придумывает число и определяет заканчивается ли на четную цифру на куб числа


bool Test(int n)
{
    return n%2==0;
//     if (n%2==0)
//         return true;
//     else
//         return false;
}
Random random=new Random(10);
for (int i=0;i<10;i++)
{
    int a=random.Next(1,100);
    int b=(int)Math.Pow(a,3);
    if (Test(a))
    System.Console.WriteLine($"{a}, {b}");
}