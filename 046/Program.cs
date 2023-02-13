// 46. Создать массив из 123 элементов
//     Заполнить случайными положительными числами от 0 до 1000
//     Найти количество элементов которые принадлежат отрезку [10,99]


int[] a=new int[123];
Random random=new Random();
for (int i=0;i<a.Length;i++)
    a[i]=random.Next(0,1000);

for (int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i]} ");
System.Console.WriteLine();

// элементы [10,99]
int count=0;
for (int i=0;i<a.Length;i++)
   if (a[i]>10 && a[i]<99)
        count=count+1;
System.Console.WriteLine($"Количество элементов {count} ");

