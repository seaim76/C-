using System;

namespace Class_obj {
    class Employee
    {

        public int id;
        public string name;
        public int age;
        public float salary;



        public void insert(int i, string n, int a, float s)
        {
            id = i;
            name = n;   
            age = a;    
            salary = s;
            
        }
        public void display()
        {
            Console.WriteLine(id+" "+ name+" "+age+" "+salary+" ");
       
        }

      public  static void Main(string[] args)
        {
            Employee e1= new Employee();
            Employee e2 = new Employee();
            Employee e3 = new Employee();
            Employee e4 = new Employee();

            e1.insert(15 ,"seaim",18,200000);
            e2.insert(15, "seaim", 18, 200000);
            e3.insert(15, "seaim", 18, 200000);
            e4.insert(15, "seaim", 18, 200000);


            e1.display();
            e2.display();   
            e3.display();   
            e4.display();
        }
    }


}

