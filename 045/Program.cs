// 45. Задать массив, заполнить случайными положительными трёхзначными числами 
// Показать количество нечетных\четных чисел

int[] a=new int[5];
Random random=new Random();
for (int i=0;i<a.Length;i++)
    a[i]=random.Next(10,1000);

for (int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i]} ");
System.Console.WriteLine();

// четные/нечетные
int count1=0;
int count2=0;
for (int i=0;i<a.Length;i++)
    if (a[i]%2==0)
        count1=count1+1;
    else 
        count2=count2+1;
System.Console.WriteLine($"Четных чисел {count1}");
System.Console.WriteLine($"Нечетных чисел {count2}");
