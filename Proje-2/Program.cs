using System.Collections;
Dictionary<int,string> members = new Dictionary<int, string>();
members.Add(0,"oğuz");
members.Add(1,"çaycı");
members.Add(2,"stajyer");
members.Add(3,"ev sahibi");

List<string[]> to_Do_List = new List<string[]>();
List<string[]> in_Progress_List = new List<string[]>();
List<string[]> done_List = new List<string[]>();



fuctions fuction = new fuctions(to_Do_List,in_Progress_List,done_List);
//("id","Başlık","İçerik","Sorumlu Kişi","Durum","Sorumlu kişi id");
string[] card0 = {"1","Alışveriş","Süt,yumurta petetes","Deli hüseyin","ufak","1","0"};
string[] card1 = {"2","spor","para","Deli oguz","orta","0"};
string[] card2 = {"3","kafa dinleme","works","sinan hüseyin","büyük","0","1"};

to_Do_List.Add(card0);
to_Do_List.Add(card1);
in_Progress_List.Add(card2);

fuction.listing_ToDo_Card();


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
    List<string[]> to_Do_List = new List<string[]>();
    List<string[]> in_Progress_List = new List<string[]>();
    List<string[]> done_List = new List<string[]>();

    public fuctions(List<string[]> to_do,List<string[]> in_progress,List<string[]> done){
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
            Console.WriteLine("Başlık: "+to_Do_List[i][1]);
            Console.WriteLine("İçerik: "+to_Do_List[i][2]);
            Console.WriteLine("Atanan Kişi: "+to_Do_List[i][3]);
            Console.WriteLine("Zorluk:"+to_Do_List[i][4]);
            Console.WriteLine("-");
        }

        //In progress Listing
        Console.WriteLine(" IN PROGRESS Line");
        Console.WriteLine("**********************");
        if(in_Progress_List.Count==0) Console.WriteLine("~Boş~");
        for (int i = 0; i < in_Progress_List.Count; i++)
        {
            Console.WriteLine("Başlık: "+in_Progress_List[i][1]);
            Console.WriteLine("İçerik: "+in_Progress_List[i][2]);
            Console.WriteLine("Atanan Kişi: "+in_Progress_List[i][3]);
            Console.WriteLine("Zorluk:"+in_Progress_List[i][4]);
            Console.WriteLine("-");
        }

        //Done Listing
        Console.WriteLine("Done Line");
        Console.WriteLine("***********************");
        if(done_List.Count==0) Console.WriteLine("~Boş~");
        for (int i = 0; i < done_List.Count; i++)
        {
            Console.WriteLine("Başlık: "+done_List[i][1]);
            Console.WriteLine("İçerik: "+done_List[i][2]);
            Console.WriteLine("Atanan Kişi: "+done_List[i][3]);
            Console.WriteLine("Zorluk:"+done_List[i][4]);            
            Console.WriteLine("-");
        }

    }
}