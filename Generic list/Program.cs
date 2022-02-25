List<int> numberlist = new List<int>();
numberlist.Add(1);
numberlist.Add(13);
numberlist.Add(1663);
numberlist.Add(143223);
List<string> colors = new List<string>();
colors.Add("mor");
colors.Add("eflatun");
colors.Add("turuncu");

foreach (var item in numberlist)
{
    Console.WriteLine(item);
}
colors.ForEach(color => Console.WriteLine(color));

// Listeden eleman çıkartma

colors.Remove("sarı");
numberlist.RemoveAt(1);

// Removeat index olarak çıkartma

numberlist.Contains(1); //boolean ifade döner

// eleman ile indexi bulma
numberlist.BinarySearch(2);

//diziyi liste dönüştürme

string[] cars = { "f1", "traktör", "taksi" };

List<string> carslist = new List<string>(cars);

carslist.Clear();

users users1=new users();
users1.First_name="oguz";
users1.Last_name="umut";
users1.Yas="22";


List<users> userslist = new List<users>();

userslist.Add(users1);

//yeni yazarak ekleme

userslist.Add(new users(){
    First_name="ramazan"
});

foreach (var item in userslist)
{
    Console.WriteLine(item.First_name);
}


//Encapsulation
public class users
{
    string  first_name, last_name, yas;

    public string First_name { get => first_name; set => first_name = value; }
    public string Last_name { get => last_name; set => last_name = value; }
    public string Yas { get => yas; set => yas = value; }

}