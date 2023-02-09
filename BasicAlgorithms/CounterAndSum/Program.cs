// Подсчитать количество цифр и сумму цифр

int N=1234;
int counter=0; //счетчик
int sum=0;//сумматор

while(N!=0) // пока N не ранвно 0
{
    //counter=counter+1;
    counter++;
    int d=N%10;
    //sum=sum+d;
    sum+=d;
    //N=N/10;
    N/=10;
}
System.Console.WriteLine(counter);
System.Console.WriteLine(sum);