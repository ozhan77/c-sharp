Dictionary<int,string> users = new Dictionary<int, string>();
users.Add(1,"oz");
users.Add(2,"umut");
users.Add(3,"bürütüs");

Console.WriteLine(users[2]);

foreach (var item in users)
{
    Console.WriteLine(item);
}
users.Remove(6);


foreach (var item in users.Keys)
{
    Console.WriteLine(item);
}
foreach (var item in users.Values)
{
    Console.WriteLine(item);
}