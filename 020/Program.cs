// 20. Дано число. Проверить кратно ли оно 7 и 23

int a;
a=Convert.ToInt32(Console.ReadLine());
// if (a % 7 == 0 | a % 23 == 0)
//  System.Console.WriteLine("Число кратно 7 или 23");
// else 
//  System.Console.WriteLine("Число не кратно 7 или 23");

if (a % 7 == 0)
 System.Console.WriteLine("Число кратно 7");
   else if (a % 23 == 0)
 System.Console.WriteLine("Число кратно 23");
else 
 System.Console.WriteLine("Число не кратно 7 или 23");