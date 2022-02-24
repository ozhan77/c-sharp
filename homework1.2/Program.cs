Console.WriteLine("2 sayı gir");

int x=Convert.ToInt32(Console.ReadLine()),y=Convert.ToInt32(Console.ReadLine());

Console.WriteLine(x+" adet sayı gir la!");
int[] arr = new int[x];
for (int i = 0; i < x; i++)
{
    arr[i]=Convert.ToInt32(Console.ReadLine());
}
foreach (var item in arr)
{
    if (item==y || 0 == item % y)
    {
        Console.WriteLine(item);
    }
}