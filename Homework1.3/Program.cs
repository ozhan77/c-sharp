Console.WriteLine("enter the mayrrix");
int adet=Convert.ToInt32(Console.ReadLine());
string[] arr= new string[adet];

Console.WriteLine(adet + " adet kelime gir bakim");

for (int i = 0; i < adet; i++)
{
    arr[i]=Console.ReadLine();
}
foreach (var item in arr.Reverse())
{
    Console.WriteLine(item);
}