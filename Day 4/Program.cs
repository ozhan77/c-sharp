﻿using System;
using System.Collections.Generic;
using System.IO;

class Person {
    public int age;     
	public Person(int initialAge) {
        if (initialAge<0)
        {
            this.age=0;
            Console.WriteLine("Age is not valid, setting age to 0");
        }
        else    this.age=initialAge;
     }
     public void amIOld() {
        // Do some computations in here and print out the correct statement to the console
        if (age<13)
        {
            Console.WriteLine("you are young.");
        }
        else if (age>13 && age<18)
        {
            Console.WriteLine("you are a teenager");
        }
        
     }

     public void yearPasses() {
        // Increment the age of the person in here
        age++;
     }

static void Main(String[] args) {
        int T=int.Parse(Console.In.ReadLine());
        for (int i = 0; i < T; i++) {
            int age=int.Parse(Console.In.ReadLine());
            Person p=new Person(age);
             p.amIOld();
                for (int j = 0; j < 3; j++) {
                  p.yearPasses();
                }
                p.amIOld();
                Console.WriteLine();
        }
    }
}
