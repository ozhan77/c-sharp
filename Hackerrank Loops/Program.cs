int n = 5;
string txt="";

for (int i = 1; i <= n; i++)
{
    txt="";
    int j = n-i;
    for (;j >= 0; j--)
    {
        txt += " ";
    }
    for (int k = 0; k < i; k++)
    {
        txt += "#";
    }
    Console.WriteLine(txt);
}