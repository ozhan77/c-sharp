
Console.WriteLine(days.sunday);
Console.WriteLine((int)days.mondoay);

if (10<(int)tempcure.warm)
{
    Console.WriteLine("üşüdük reiz");
}
else if (-10<(int)tempcure.cold)
{
    Console.WriteLine("soba yakalım");
}
else if (50>(int)tempcure.hell)
{
    Console.WriteLine("yanıyoz aq");
}

enum days
{
    mondoay,sunday,tuesday,wednesday,tursdayfriday,saturday
}
enum tempcure
{
    toCold=-10,cold =0,normal=15,warm=25,hot=35,hell=42
}