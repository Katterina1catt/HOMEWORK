int a=75,b=10005;

while(a!=b)
    if(a>b)
        a-=b; // a=a-b
    else
        b-=a;
System.Console.WriteLine(a);
