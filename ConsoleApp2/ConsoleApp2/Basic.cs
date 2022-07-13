using System;

namespace App2
{
    class Basic
    {

        static void Main(string[] args)
        {
            //Basic Understand of String
            //string Mess = "Hello World";
            //Mess = " ";
            //Console.WriteLine(Mess);
            //Console.WriteLine("Mess");
            //Mess = "Hello";
            //Console.Write(Mess);
            //Mess = "World";
            //Console.WriteLine(Mess);


            //Use of concate
            //int num = 50;
            //Console.WriteLine(num+50);
            //Console.WriteLine(" Result is :\n\n " + num+50);//Result is 5050 string Concate
            //Console.WriteLine(Environment.NewLine+"Result is :" +(num+50));

            //User input
            //Console.Write("Enter Yor Name:");
            //string name = Console.ReadLine();
            //Console.WriteLine("Hi "+name);    



            //Typecasting

            //Console.Write("Enter Num1 :");
            //int Num1= Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter Num2 :");
            //int Num2 = Convert.ToInt32(Console.ReadLine());

            //int result = Num1 + Num2;
            //Console.WriteLine("Result is :"+result);


            //Console.Write("Enter Your C#  Marks:");
            //int marks =Convert.ToInt32(Console.ReadLine());
            //if (marks >= 50)
            //{
            //    Console.WriteLine("You pass The Exam !");
            //}
            //else
            //{
            //    Console.WriteLine("You fail the Exam !");            
            //}


            //Console.Write("Enter Yor Name:");
            //string name = Console.ReadLine();
            //Console.Write("Enter Your C#  Marks:");
            //int marks = Convert.ToInt32(Console.ReadLine());
            //string result;
            //if (marks >= 50)
            //{
            //    result = "Passed";
            //}
            //else
            //{
            //    result = "Failed";
            //}
            //Console.WriteLine(" Hi "+ name + " You have " + result + " The exam ");


            int[] numbers = new int[5] { 5,6,1,4,7};
            for (int i = 0; i < numbers.Count(); i++) 
            {
                Console.WriteLine(numbers[i]);
            }




        }


    }




}