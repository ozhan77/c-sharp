using System.Collections;

ArrayList vowels=new ArrayList(){"a","e","i","o","u"};
ArrayList result=new ArrayList();

string[] trueVowel={"a","e","i","o","u"};

Console.WriteLine("ali tut");
string txt = Console.ReadLine();

for (int i = 0; i < txt.Length; i++)
{
    Console.WriteLine("txt değeri"+txt[i]);
    if (trueVowel.Contains(txt[i].ToString()))
    {
        result.Add(txt[i].ToString());
    }
    
}
result.Sort();
foreach (var item in result)
    {
        Console.WriteLine(item);
    }