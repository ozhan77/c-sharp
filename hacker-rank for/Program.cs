int[] candles={5,3,4,2,2,4,5,3,5,5};
int high=0,count=0;
for (int i = 1; i < candles.Count(); i++)
{
    if (candles[i]>high)
    {
        high=candles[i];
    }
}
var total = candles.Count(n=> n==high);
Console.WriteLine(total);