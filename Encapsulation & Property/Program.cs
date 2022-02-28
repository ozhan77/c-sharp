student std1= new student ("oguz","umut",1,32);
student std2= new student ("memet","daskaya",2,34);
std1.ascending();
std2.Student_class=0;


class student{
    private string first_name;
    private string last_name;
    private int student_number;
    private int student_class;


    public string First_name { 
        get  {return first_name;}
        set {first_name = value;} 
    }

    public string Last_name { get => last_name; set => last_name = value; }
    public int Student_number { get => student_number; set => student_number = value; }
    public int Student_class 
    { 
        get => student_class; 
        set 
        { 
            if(value<1) {
                Console.WriteLine("Sınıf birden küçük olamaz");
                student_class=1;
            }
            else
            student_class = value;
        }
    }

    public student(string first_name, string last_name, int student_number, int student_class){
        this.first_name=first_name;
        this.last_name=last_name;
        this.student_number=student_number;
        this.student_class=student_class;

    }
    public student(){}

    public void student_att(){
        Console.WriteLine(this.first_name);
        Console.WriteLine(this.last_name);
    }

    public void ascending(){
        this.Student_class +=1;
    }
    public void descending(){
        this.Student_class -=1;
    }
}