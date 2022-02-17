int[] arr = {-2,3,4,0,-1};
decimal pozitif=0,negatif=0,zero=0;
foreach (var item in arr)
{
    if (item>0)
    {
        pozitif++;
    }
    else if (item<0)
    {
        negatif++;
    }
    else
    {
        zero++;
    }
    
}
Console.WriteLine(pozitif/arr.Length);
Console.WriteLine(negatif/arr.Length);
Console.WriteLine(zero/arr.Length);

