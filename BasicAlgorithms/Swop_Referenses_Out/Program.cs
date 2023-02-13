
// void Swap(int x,int y); // передача по значению
// {
//     int t=x;
//     x=y;
//     y=t;
// }
// int a=4;
// int b=5;
// System.Console.WriteLine($"a={a} b={b}");
// стандартный обмен 

// int t; // стандартный обмен 
// t=a;
// a=b;
// b=t;

// a=a+b;
// b=a-b;
// a=a-b;

// void Swap(ref int x,ref int y) // передача по ссылке
// {
//     int t=x;
//     x=y;
//     y=t;
// }

void calculator(int a,int b,out int sum,out int sub)
{
    sum=a+b;
    sub=a-b;
}
// int u,r=0,o=0;
// u=r+0;

int a=4;
int b=5;
int s,sb;
calculator(a,b,out s,out sb);

// System.Console.WriteLine($"a={a} b={b}");

// Swap(ref a,ref b);
// System.Console.WriteLine($"a={a} b={b}");

