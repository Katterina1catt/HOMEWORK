//Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
double x,y;
x=Convert.ToInt32(Console.ReadLine());
y=Convert.ToInt32(Console.ReadLine());
if (x>0 && y>0) System.Console.WriteLine("Плоскость  I");
if (x<0 && y>0) System.Console.WriteLine("Плоскость  II");
if (x<0 && y<0) System.Console.WriteLine("Плоскость  III");
if (x>0 && y<0) System.Console.WriteLine("Плоскость  IV");