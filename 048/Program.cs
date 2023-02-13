// 48. Задан массив a из N элементов
// Заполнить массив случайными числами от 1 до 10
// Создайте массив, который является произведением пар чисел в одномерном массиве a.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// а) вариант когда в массиве четное кол-во элементов
// б) вариант когда в массиве и четное и не четное кол-во элементов

// массив а
int N;
N=Convert.ToInt32(Console.ReadLine());
int [] a=new int [N];
Random random=new Random();
for (int i=0;i<a.Length;i++)
    a[i]=random.Next(1,10);
for (int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i]} ");
System.Console.WriteLine();


// произведение пар чисел массива а 
// а) вариант когда в массиве четное кол-во элементов

// int [] b=new int [N/2];
// if (N%2==0)
// {
//     for (int i=0;i<b.Length;i++)
//         b[i]=a[i]*a[a.Length-i-1];
    
// for (int i=0;i<b.Length;i++)
// System.Console.Write($"{b[i]} ");
// }
// else 
// System.Console.WriteLine("Массив с нечетным количесвтом элементов");


// б) вариант когда в массиве и четное и нечетное кол-во элементов

int [] b=new int [N/2];
if (N%2==0)
{
    for (int i=0;i<b.Length;i++)
        b[i]=a[i]*a[a.Length-i-1];
    
for (int i=0;i<b.Length;i++)
System.Console.Write($"{b[i]} ");
}

else
{
        for (int i=0;i<b.Length;i++)
        b[i]=a[i]*a[a.Length-i-1];
    
for (int i=0;i<b.Length;i++)
System.Console.Write($"{b[i]} ");

//число без пары - записывается как последнее в массиве, если элементов в массиве нечетное количество
// можно не включать в массив

int lost=0;
a[lost] = a[a.Length/2];
System.Console.WriteLine(a[lost]);
}



