// 50. Написать программу копирования массива
 
public class Example
{
    public static void Main()
    {
        int[] a={5, 4, 7, 2, 9 };
 
        int[] copy=new int[a.Length];
        for (int i=0;i < a.Length;i++) 
        {
            copy[i] = a[i];
        }
 
        Console.WriteLine(String.Join(", ", copy));
    }
}