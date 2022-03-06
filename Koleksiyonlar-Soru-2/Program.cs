using System.Collections;

ArrayList arr = new ArrayList();
ArrayList low = new ArrayList();
ArrayList high = new ArrayList();
int lowAvg=0,highAvg=0;

Console.WriteLine("10 adet sayı giriniz");

for (int i = 0; i < 10; i++)
{
    int num1=Convert.ToInt16(Console.ReadLine());
    arr.Add(num1);
}
arr.Sort();

for (int i = 0; i < 3; i++)
{
    low.Add(arr[i]);
}
for (int i = 9; i > 6; i--)
{
    high.Add(arr[i]);
}
Console.WriteLine("low array");
foreach (var item in low)
{
    Console.WriteLine(item);
}
Console.WriteLine("high array");
foreach (var item in high)
{
    Console.WriteLine(item);
}
for (int i = 0; i < 3; i++)
{
    lowAvg +=Convert.ToInt16(low[i]);
    highAvg +=Convert.ToInt16(high[i]);
}

Console.WriteLine((decimal)lowAvg/3);
Console.WriteLine((decimal)highAvg/3);