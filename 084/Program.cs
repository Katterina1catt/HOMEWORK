// 84. Определить являются ли введенные с клавиатуры символы правильно записью целого числа.
// Вычислить сумму цифр введенного числа


ConsoleKeyInfo keyInfo=Console.ReadKey();

char c=keyInfo.KeyChar;

System.Console.WriteLine((int)c);

int n=(int)c;
int counter=0;
int sum=0;
while(n!=0)
{    
    sum+=n%10;
    counter++;
    n=n/10;
}
System.Console.WriteLine(sum);

