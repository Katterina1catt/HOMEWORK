// Программа проверяет пятизначное число на палиндромом. Например: 12321

int n;
n=Convert.ToInt32(Console.ReadLine());
int t0,t1,t2,t3,t4;
t4=n/10000%10;
t3=n/1000%10;
t2=n/100%10;
t1=n/10%10;
t0=n%10;
if (t4 == t0 && t3 == t1)
System.Console.WriteLine("Число является полиндромом");
else 
System.Console.WriteLine("Число не является полиндромом");
