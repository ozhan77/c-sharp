using System.Collections;

ArrayList arr = new ArrayList();
ArrayList prime = new ArrayList();
ArrayList nunPrime = new ArrayList();

Console.WriteLine("20 adet sayı girin");
for (int i = 0; i < 5; i++)
{
    try
    {
        int num1 = Convert.ToInt16(Console.ReadLine());
        if (IsPrime(num1))
        {
            arr.Add(num1);
            prime.Add(num1);
        }
        else if(IsPrime(num1)==false && num1>0)
        {
            arr.Add(num1);
            nunPrime.Add(num1);
        }

    }
    catch (System.Exception)
    {
        Console.WriteLine("Geçerli bir değer girin");
        continue;
    }


}
foreach (var item in arr)
{
    Console.WriteLine(item);
}
Console.WriteLine("prime numbers");
foreach (var item in prime)
{
    Console.WriteLine(item);
}
Console.WriteLine("nunprime numbers");
foreach (var item in nunPrime)
{
    Console.WriteLine(item);
}



static bool IsPrime(int number)
{
    if (number <= 1) return false;
    if (number == 2) return true;
    if (number % 2 == 0) return false;

    var boundary = (int)Math.Floor(Math.Sqrt(number));

    for (int i = 3; i <= boundary; i += 2)
        if (number % i == 0)
            return false;

    return true;
}


