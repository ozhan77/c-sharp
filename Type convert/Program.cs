byte  a =5;
sbyte b = 42;
short c = 103;


int d = a+b+c;
Console.WriteLine(d);

long l1= d;

Console.WriteLine(l1);

float f1=l1;

Console.WriteLine(f1);


object obj =f1+l1;
Console.WriteLine("************ Explict Conversion ****************");

int number1 = 12;
byte bnumber = (byte)number1;
Console.WriteLine(bnumber);

float float_number= 142;
byte test1 = (byte)float_number;
Console.WriteLine(test1);

Console.WriteLine("ToString Metodu");

int x_number=77;
string txt1="vada";
Console.WriteLine(txt1+x_number.ToString());

string faketxt="99";
Console.WriteLine(x_number+Convert.ToInt16(faketxt));

ParseMethod();

void ParseMethod()
{
    string txt2="12";
    string txt3="453.2241";
    int number12=31;
    double double_number;

    number12=Int16.Parse(txt2);
    double_number=double.Parse(txt3);

    Console.WriteLine(number12);
    Console.WriteLine(double_number);

}


