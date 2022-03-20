Dictionary<string,string> phoneBook = new Dictionary<string, string>();

phoneBook.Add("oğuz","085055599");
phoneBook.Add("gaftici feti","583492375");
phoneBook.Add("jefbezoz","0532250395");
phoneBook.Add("markzakırbörg","493472346542");
phoneBook.Add("barbara","45026745732");


menus menu = new menus();
menu.mainMenu();
int selected=Convert.ToInt32(Console.ReadLine());

fuctions fuction=new fuctions(phoneBook);

switch (selected)
{
    case 1:
        fuction.addNumber();
        break;
    case 2:
        menu.updateNumber();
        fuction.removeNumber(Console.ReadLine());
        break;
    case 3:
        menu.updateNumber();
        fuction.updateNumber(Console.ReadLine());
        break;
    case 4:
        menu.listPhonebook();

        foreach (var item in phoneBook)
        {
            Console.WriteLine("İsim: "+item.Key);
            Console.WriteLine("Soyisim: "+item.Value);
            Console.WriteLine("-");
        }
        break;
    case 5:

    default:break;
}
foreach (var item in phoneBook)
{
    Console.WriteLine("main"+item);
}


class menus
{
    public void mainMenu(){
        Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
        Console.WriteLine("*******************************************");
        Console.WriteLine("(1) Yeni Numara Kaydetmek");
        Console.WriteLine("(2) Varolan Numarayı Silmek");
        Console.WriteLine("(3) Varolan Numarayı Güncelleme");
        Console.WriteLine("(4) Rehberi Listelemek");
        Console.WriteLine("(5) Rehberde Arama Yapmak");
    }
    public void addNumber(){
        
    }
    public void removeNumber(){
        Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");

    }

    public void lastCheck(){
        Console.WriteLine("Örnek isim"+"isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)");
    }
    public void updateNumber(){
        Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz:");
    }
    public void listPhonebook(){
        Console.WriteLine("Telefon Rehberi");
        Console.WriteLine("**********************************************");

    }
    public void searchNumber(){
        Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
        Console.WriteLine("**********************************************");
        Console.WriteLine("");
        Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
        Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
    }

    public void listSearchResult(){
        Console.WriteLine(" Arama Sonuçlarınız:");
        Console.WriteLine("**********************************************");
        

    }
    public void tryAgainUpdate(){
        Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
        Console.WriteLine(" * Güncellemeyi sonlandırmak için   : (1)");
        Console.WriteLine("* Yeniden denemek için              : (2)");
    }
    public void tryAgainDelete(){
        Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
        Console.WriteLine(" * Silmeyi sonlandırmak için    : (1)");
        Console.WriteLine("* Yeniden denemek için          : (2)");
    }
}
class fuctions
{

    menus menu=new menus();
    Dictionary<string,string> phoneBook = new Dictionary<string, string>();

    public fuctions(Dictionary<string,string> phoneBook){
        this.phoneBook=phoneBook;
    }
    public void addNumber(){
        Console.WriteLine("Lütfen isim giriniz:");
        string name = Console.ReadLine();
        Console.WriteLine("Lütfen telefon numarası giriniz :");
        string number = Console.ReadLine();
        phoneBook.Add(name,number);
    }
    public void removeNumber(string name){
        if (includeName(name))
        {
            menu.lastCheck();
            if(Console.ReadLine()=="y"){
                phoneBook.Remove(name);
            }
            
        }
        else {
            menu.tryAgainDelete();
            if (Console.ReadLine()=="2")
            {
                menu.removeNumber();
                removeNumber(Console.ReadLine());
            }
        }
    }
    public void listPhonebook(){

        Console.WriteLine("İsim:");
        Console.WriteLine("Telefon Numarası");

    }
    public void updateNumber(string name){
        if(includeName(name)){
            Console.WriteLine("İsim giriniz");
            string newName=Console.ReadLine();
            Console.WriteLine("Numara giriniz");
            string newNumber = Console.ReadLine();
            var oldNumber=phoneBook.TryGetValue(name, out string oldNum);
            

        }
    }
    private bool includeName(string name){

        if (phoneBook.ContainsKey(name))
        {
            return true;
        }
        else return false;
    }
    private bool includeNumber(string number){
        if (phoneBook.ContainsValue(number))
        {
            return true;
        }
        else return false;
    }
}