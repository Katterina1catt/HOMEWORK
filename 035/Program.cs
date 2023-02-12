// 35. Подсчитать сумму цифр в числе. Сделать подпрограмму.

int n;
n=Convert.ToInt32(Console.ReadLine());
int counter=0;
int sum=0;
while(n!=0)
{    
    sum+=n%10;
    counter++;
    n=n/10;
}
System.Console.WriteLine(sum);
