// 54. С клавиатуры вводится число N. 
// Показать первые N чисел Фибоначчи. Принять первые числа равными 0 и 1

int N;
N = Convert.ToInt32(Console.ReadLine());
int[] f = new int[N];
int a0=0;
int a1=1;
f[0]=a0;
f[1]=a1;

for(int i=2;i<N;i++)
{
    int a=a0+a1;
    f[i]=a;
    a0=a1;
    a1=a;
}
for(int i=0;i<f.Length;i++)
System.Console.Write($"{f[i]} ");
