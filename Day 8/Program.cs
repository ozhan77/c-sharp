using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        Dictionary<string,string> phoneBook=new Dictionary<string, string>();

        int n = Convert.ToInt16(Console.ReadLine());
        string,check;

        for (int i = 0; i < n; i++)
        {
            txt=Console.ReadLine();
            splitter=txt.Split(' ');
            phoneBook.Add(splitter[0].ToLower(),splitter[1]);
        }
        for (int i = 0; i < n; i++)
        {
            
        }
        
        for (int i = 0; i < n; i++)
        {
            check=Console.ReadLine();
            
            if (phoneBook.TryGetValue(check, out string value))
            {
                Console.WriteLine(check+"="+value);
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }

        // Alternatif çözüm

        int n = Convert.ToInt32(Console.ReadLine());
        int x=0;
        Dictionary<string, string> myBook = new Dictionary<string, string>();    
        while (x<n){
            
            var s = Console.ReadLine().Split(' ');
            var name = s[0];
            var phoneNumber = s[1];
   
             
            myBook.Add(name, phoneNumber);        
      
            x++;
        }  
        string searchedName;
        while((searchedName=Console.ReadLine())  != null){
            
            if (myBook.ContainsKey(searchedName)){
                Console.WriteLine(searchedName+"="+myBook[searchedName]);                
            }
            else{
                Console.WriteLine("Not found");
            }
        }

    }
}
