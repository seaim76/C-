
using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace Task1

{



    class BankAccount

    {

        private string username, password, gender;

        private int age, initbalance;

        public void setAge(int age)

        {

            if (age > 18 && age < 150)

            {

                this.age = age;

            }

            else

            {

                Console.WriteLine("Invalid age!!");



            }



        }



        public void setGender(string gender)

        {

            if (gender == "M" || gender == "F")

            {

                this.gender = gender;

            }

            else

            {

                Console.WriteLine("Invalid gender!");



            }

        }





        public void setInitialBal(int initbalance)

        {

            if (initbalance >= 1000)

            {

                this.initbalance = initbalance;

            }

            else

            {

                Console.WriteLine("Insufficient balance!");



            }

        }

        public void setpassword(string password)

        {

            this.password = password;



        }



        public int getAge()

        {

            return this.age;

        }



        public string getGender()

        {

            return this.gender;

        }



        public int getInitialBal()

        {

            return this.initbalance;

        }



    }

    class Program

    {

        static void Main(string[] args)

        {

            Console.WriteLine("Encapsulation ");

            BankAccount b = new BankAccount();

            b.setAge(50);

            b.setInitialBal(3000);

            b.setGender("M");

            b.setpassword("123");



            Console.WriteLine("Enter username :");





            string userName = Console.ReadLine();
            Console.WriteLine("Your name is " +userName);
            Console.WriteLine("Enter Your Password:");

            string password = Console.ReadLine();


            Console.WriteLine("Username is: " + userName);



            if (userName == "seaim" && password == "123")

            {

                Console.WriteLine(b.getAge());

                Console.WriteLine(b.getGender());

                Console.WriteLine(b.getInitialBal());

            }

            else

            {

                Console.WriteLine("Invalid");

            }

        }

    }

}