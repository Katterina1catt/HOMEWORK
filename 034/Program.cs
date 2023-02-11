// 34. Определить количество цифр в числе. Сделать подпрограмму.

// int n=1234;
// int counter=0;
// while(n!=0)
// {
//     counter++;
//     n/=10; 
// }
// System.Console.WriteLine(counter);

int CounerDigits(int n)
{
    if (n==0) return 1; //пограничный случай
    int counter=0;
    while(n!=0)
    {
    counter++;
    n/=10; 
    }
    return counter;
}

System.Console.WriteLine(CounerDigits(56878));