int number1;

Console.WriteLine("Bir sayı girin");
number1=Convert.ToInt16(Console.ReadLine());

int[] arr = new int[number1];
Console.WriteLine(number1+" Adet sayı girin");

for (int i = 0; i < number1; i++)
{
    
    arr[i]= Convert.ToInt16(Console.ReadLine());
    
}
Console.WriteLine("Çift Sayılar");
foreach (var item in arr)
{
    if (0==item % 2)
    {
        Console.WriteLine(item);
    }
}

