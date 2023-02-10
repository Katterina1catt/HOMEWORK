// 11. Дано число больше 9. Вывести на экран вторую цифру числа с конца
int n=12435;
int d0,d1,d2;
d0=n%10;
d1=n/10%10;
d2=n/100%10;
System.Console.WriteLine($"{d0} {d1} {d2}");
System.Console.WriteLine($"{d1}");
