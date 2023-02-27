// 88. Заменить все вхождения подстроки w в строке st на строку v. 
// Вывести на экран первоначальную строку и конечную строку

string s=" Advantages of the global network are obvious."
        +"Internet is a worldwide network.";
System.Console.WriteLine(s);
System.Console.WriteLine();
string s1="w";
string s2="v";
s=s.Replace(s1,s2);
System.Console.WriteLine(s);

