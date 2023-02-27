// 86. Подсчитать сколько раз определенный символ (например 'a')
// встречается в строке.


string s="It's a simple. task Yes!";
char letter = 't';
int g=s.Count(ch=>ch==letter); 

System.Console.WriteLine(g);

