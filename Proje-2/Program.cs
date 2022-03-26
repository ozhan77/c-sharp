using System.Collections;
Dictionary<string,string> members = new Dictionary<string, string>();
members.Add("0","oğuz");
members.Add("1","çaycı");
members.Add("2","stajyer");
members.Add("3","ev sahibi");

List<string[]> to_Do_List = new List<string[]>();
List<string[]> in_Progress_List = new List<string[]>();
List<string[]> done_List = new List<string[]>();



fuctions fuction = new fuctions(members,to_Do_List,in_Progress_List,done_List);
//("Başlık","İçerik","Sorumlu Kişi","Durum");
string[] card0 = {"Alışveriş","Süt,yumurta petetes","Deli hüseyin","ufak"};
string[] card1 = {"spor","para","Deli oguz","orta"};
string[] card2 = {"kafa dinleme","works","sinan hüseyin","büyük"};

to_Do_List.Add(card0);
to_Do_List.Add(card1);
in_Progress_List.Add(card2);

while (true)
{
    Console.WriteLine(" Lütfen yapmak istediğiniz işlemi seçiniz :)");
    Console.WriteLine(" *******************************************");
    Console.WriteLine("(1) Board Listelemek");
    Console.WriteLine("(2) Board'a Kart Eklemek");
    Console.WriteLine("(3) Board'dan Kart Silmek");
    Console.WriteLine("(4) Kart Taşımak");
    string menuKey=Console.ReadLine();
    if (menuKey=="1")
    {
        fuction.listing_ToDo_Card();
    }
    else if (menuKey=="2")
    {
        fuction.addCard();
    }
    else if (menuKey=="3")
    {
        fuction.deleteCard();
    }
    else if (menuKey=="4")
    {
        fuction.change_Status();
    }
    else
    {
        Console.WriteLine("Hatalı Menü Anahtarı");
    }

}
class toDoCard
{
    
    public toDoCard(){
        
    }
    public void addCard(){
        for (int i = 0; i < 5; i++)
        {
            
        }
        
    }
}

class fuctions{
    Dictionary<string,string> members = new Dictionary<string, string>();
    List<string[]> to_Do_List = new List<string[]>();
    List<string[]> in_Progress_List = new List<string[]>();
    List<string[]> done_List = new List<string[]>();

    public fuctions(Dictionary<string,string> members,List<string[]> to_do,List<string[]> in_progress,List<string[]> done){
        this.members=members;
        this.to_Do_List=to_do;
        this.in_Progress_List=in_progress;
        this.done_List=done;
    }
    public void listing_ToDo_Card(){
        Console.WriteLine("TODO Line");
        Console.WriteLine("**********************");
        if(to_Do_List.Count==0) Console.WriteLine("~Boş~");
        for (int i = 0; i < to_Do_List.Count; i++)
        {
            Console.WriteLine("Başlık: "+to_Do_List[i][0]);
            Console.WriteLine("İçerik: "+to_Do_List[i][1]);
            Console.WriteLine("Atanan Kişi: "+to_Do_List[i][2]);
            Console.WriteLine("Zorluk:"+to_Do_List[i][3]);
            Console.WriteLine("-");
        }

        //In progress Listing
        Console.WriteLine(" IN PROGRESS Line");
        Console.WriteLine("**********************");
        if(in_Progress_List.Count==0) Console.WriteLine("~Boş~");
        for (int i = 0; i < in_Progress_List.Count; i++)
        {
            Console.WriteLine("Başlık: "+in_Progress_List[i][0]);
            Console.WriteLine("İçerik: "+in_Progress_List[i][1]);
            Console.WriteLine("Atanan Kişi: "+in_Progress_List[i][2]);
            Console.WriteLine("Zorluk:"+in_Progress_List[i][3]);
            Console.WriteLine("-");
        }

        //Done Listing
        Console.WriteLine("Done Line");
        Console.WriteLine("***********************");
        if(done_List.Count==0) Console.WriteLine("~Boş~");
        for (int i = 0; i < done_List.Count; i++)
        {
            Console.WriteLine("Başlık: "+done_List[i][0]);
            Console.WriteLine("İçerik: "+done_List[i][1]);
            Console.WriteLine("Atanan Kişi: "+done_List[i][2]);
            Console.WriteLine("Zorluk:"+done_List[i][3]);            
            Console.WriteLine("-");
        }

    }
    public void addCard(){
        Console.WriteLine("Başlık Giriniz                                  :");
        string title = Console.ReadLine();
        Console.WriteLine("İçerik Giriniz                                  :");
        string content = Console.ReadLine();
        Console.WriteLine("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  :");
        string size = Console.ReadLine();
        string difficulty;
        if(size=="1") difficulty="XS";
        else if(size=="2") difficulty="S";
        else if(size=="3") difficulty="M";
        else if(size=="4") difficulty="L";
        else if(size=="5") difficulty="XL";
        Console.WriteLine(" Kişi ID Giriniz                                    :");
        string userid=Console.ReadLine();
        string userName;
        while (true)
        {
            if(members.ContainsKey(userid)){
            members.TryGetValue(userid, out userName);
            break;
            }
            else Console.WriteLine("Hatalı Giriş yaptınız.");

        }
        string[] newToDoCard = {title,content,userName,size,userid};
        to_Do_List.Add(newToDoCard);
        
    }
    public void deleteCard(){
        bool seachMoto=true;
        while (seachMoto)
        {
            Console.WriteLine("Lütfen kart başlığını yazınız:");
            string delete_Key = Console.ReadLine();
            
                for (int i = 0; i < to_Do_List.Count; i++)
                {
                    if (to_Do_List[i][0]==delete_Key)
                    {
                        to_Do_List.RemoveAt(i);
                        Console.WriteLine("Silme İşlemi Başarılı");
                        seachMoto=false;
                        return;
                    }
                }
                for (int i = 0; i < in_Progress_List.Count; i++)
                {
                    if (in_Progress_List[i][0]==delete_Key)
                    {
                        in_Progress_List.RemoveAt(i);
                        Console.WriteLine("Silme İşlemi Başarılı");
                        seachMoto=false;
                        return;
                        
                    }
                }
                for (int i = 0; i < done_List.Count; i++)
                {
                    if (to_Do_List[i][0]==delete_Key)
                    {
                        to_Do_List.RemoveAt(i);
                        Console.WriteLine("Silme İşlemi Başarılı");
                        seachMoto=false;
                        return;
                    }
                }
            
                Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için : (2)");
                string select=Console.ReadLine();
                if(select=="1")break;
                else if (select=="2") continue;
            
        }
    }
    public void change_Status(){
        
        bool seachMoto=true;
        while (seachMoto)
        {
            
            Console.WriteLine("Öncelikle Değiştirmek istediğiniz kartı seçmeniz gerekiyor.");
            Console.WriteLine("Lütfen kart başlığını yazınız:");
            string card_key=Console.ReadLine();
                for (int i = 0; i < to_Do_List.Count; i++)
                {
                    if (to_Do_List[i][0]==card_key)
                    {
                        showCard(i,to_Do_List[i][0],to_Do_List[i][1],to_Do_List[i][2],to_Do_List[i][3],"ToDo");
                        return;
                    }
                }
                for (int i = 0; i < in_Progress_List.Count; i++)
                {
                    if (in_Progress_List[i][0]==card_key)
                    {
                        showCard(i,in_Progress_List[i][0],in_Progress_List[i][1],in_Progress_List[i][2],in_Progress_List[i][3],"In Progress");
                        return;
                        
                    }
                }
                for (int i = 0; i < done_List.Count; i++)
                {
                    if (to_Do_List[i][0]==card_key)
                    {
                        showCard(i,done_List[i][0],done_List[i][1],done_List[i][2],done_List[i][3],"Done");
                        return;
                    }
                }
            
                Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Güncellemeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için : (2)");
                string select=Console.ReadLine();
                if(select=="1")break;
                else if (select=="2") continue;
        }

    }
    protected void showCard(int index ,string title, string content, string personel, string size , string line){

        Console.WriteLine("Bulunan Kart Bilgileri:");
        Console.WriteLine("**************************************");
        Console.WriteLine("Başlık      :"+title);
        Console.WriteLine("İçerik      :"+content);
        Console.WriteLine("Atanan Kişi :"+personel);
        Console.WriteLine("Büyüklük    :"+size);
        Console.WriteLine("Line        :"+line);
        Console.WriteLine("");
        Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz: ");
        Console.WriteLine("(1) ToDO");
        Console.WriteLine("(2) IN PROGRESS");
        Console.WriteLine("(3) DONE");

        if (line=="ToDo")
        {
            to_Do_List.RemoveAt(index);
        }
        else if (line=="In Progress")
        {
            in_Progress_List.RemoveAt(index);
        }
        else if (line=="Done")
        {
            done_List.RemoveAt(index);
        }
        
        while (true)
        {
            string changeIndex=Console.ReadLine();
            if (changeIndex=="1")
            {
                string[] card = {title,content,personel,size};
                to_Do_List.Add(card);
                return ;
            }
            else if (changeIndex=="2")
            {
                string[] card = {title,content,personel,size};
                in_Progress_List.Add(card);
                return;
            }
            else if (changeIndex=="3")
            {
                string[] card = {title,content,personel,size};
                done_List.Add(card);
                return;
            }
            else
            {
                Console.WriteLine("Hatalı Liste");
            }
        }
    }
}