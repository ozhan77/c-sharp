Console.WriteLine("cümle yaz ulan kel");
string txt=Console.ReadLine();
string[] dilim=txt.Split(' ');
Console.WriteLine ("Harf sayısı:"+ Convert.ToString(txt.Length-dilim.Length+1) );
Console.WriteLine ("Kelime sayısı:"+Convert.ToString(dilim.Length));