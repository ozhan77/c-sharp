isci isc1= new isci("oguz","zaga","test");
Console.WriteLine(isci.Isci_sayisi);
isci isc13= new isci("oguz","zaga","test");
Console.WriteLine(isci.Isci_sayisi);

Console.WriteLine(islemler.topla(1,2));
Console.WriteLine(islemler.cikar(3,5));



class isci{
    private static int isci_sayisi;

    public static int Isci_sayisi { get => isci_sayisi;}

    private string isci_ad;
    private string isci_soyad;
    private string departman;

    static isci(){
        isci_sayisi=0;
    }

    public isci(string isci_ad,string isci_soyad,string departman){
        this.isci_ad=isci_ad;
        this.isci_soyad=isci_soyad;
        this.departman=departman;
        isci_sayisi +=1;
    }



}


static class islemler{
    public static int topla(int sayi1, int sayi2){
        return sayi1+sayi2;
    }
    public static int cikar(int sayi1, int sayi2){
        return sayi1+sayi2;
        
    }
}