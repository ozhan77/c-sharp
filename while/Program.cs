int number_1=12;
int total=0;

while(number_1>0){
    total += number_1;
    number_1--;

}
Console.WriteLine(total);
char letter='c';
while (letter<'x')
{
    Console.WriteLine(letter);
    letter--;
}
string[] notalar={"do","re","mi","sol","la","si","si","do","7 tane nota var kaç tane müzik yapılabilirki"};
foreach (var item in notalar)
{
    Console.WriteLine(item);
}