menus menu = new menus();

menu.mainMenu();



class menus
{
    public void mainMenu(){
        Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
        Console.WriteLine("*******************************************");
        Console.WriteLine("(1) Yeni Numara Kaydetmek");
        Console.WriteLine("(2) Varolan Numarayı Silmek");
        Console.WriteLine("(3) Varolan Numarayı Güncelleme");
        Console.WriteLine("(5) Rehberde Arama Yapmak");
    }
    public void addNumber(){
        Console.WriteLine("Lütfen isim giriniz             :");
        Console.WriteLine("Lütfen soyisim giriniz          :");
        Console.WriteLine("Lütfen telefon numarası giriniz :");
    }
    public void removeNumber(){
        Console.WriteLine("Lütfen telefon numarası giriniz :");
    }
}