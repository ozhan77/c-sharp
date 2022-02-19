int[] arr = {1,2,5,7,8,4,7,5};

foreach (var item in arr)
{
    Console.WriteLine(item);
}
Array.Reverse(arr);

foreach (var item in arr)
{
    Console.WriteLine(item);
}

Array.Clear(arr,1,3);

foreach (var item in arr)
{
    Console.WriteLine(item);
}
Array.Reverse(arr);

foreach (var item in arr)
{
    Console.WriteLine(item);
}