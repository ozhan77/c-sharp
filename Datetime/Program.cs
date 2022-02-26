Console.WriteLine(DateTime.Now);

string s=Convert.ToString(DateTime.Now.TimeOfDay);

Console.WriteLine(s);

string time="01:05:45PM";

DateTime dt=Convert.ToDateTime(time);

Console.WriteLine(dt.ToString("HH:mm:ss"));


Console.WriteLine(DateTime.Now.DayOfYear);
Console.WriteLine(DateTime.Now.ToLongTimeString);


Console.WriteLine(DateTime.Now.ToString("yyy"));

Console.WriteLine(Math.Abs(-23));//Mutlak değer
Console.WriteLine(Math.Cos(17));//kosinüs
Console.WriteLine(Math.Ceiling(22.7));//yukarı yuvarlama
Console.WriteLine(Math.Round(25.5));//yuvarlama
Console.WriteLine(Math.Floor(23.9));//En küçük tam sayıya yuvarlama


Console.WriteLine(Math.Max(2,6));
Console.WriteLine(Math.Min(2,9));

Console.WriteLine(Math.Pow(3,4));//3 ün 4. kuvveti
Console.WriteLine(Math.Sqrt(16));



