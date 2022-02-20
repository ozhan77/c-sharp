int number_1 = 124,a=231;
metotlar mt = new metotlar();
Console.WriteLine(number_1);

static int topla(int x, int y)
{
    return x+y;
}

Console.WriteLine(topla(number_1,a));

mt.println("dfsdgafgv");


mt.println((mt.raise(ref number_1,ref a).ToString()));


class metotlar
{
    public void println(string txt)
    {
        Console.WriteLine(txt);
    }

    public int raise(ref int a, ref int b)
    {
        a++;b++;
        return a+b;
    }
}