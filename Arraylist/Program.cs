using System;
using System.Collections;

ArrayList arr = new ArrayList();

arr.Add("5lira");
arr.Add("2 adım");
arr.Add(2);
arr.Add("bir geri");

foreach (var item in arr)
{
    Console.WriteLine(item);
}

string[] tool={"çekiç","tornavida","silikon"};
int[] numbers={1,4,6,7,3,3234,543,};
List<int> numberlist= new List<int>(numbers);
//arr.Add(tool);
//arr.Add(numberlist);
arr.Sort();

foreach (var item in arr)
{
    Console.WriteLine(item);
}
