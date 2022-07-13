using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace Task2

{



    class BankAccount

    {

        private string username, password, gender;

        private int age, initbalance;


        public int Age

        {

            set { age = value; }

            get { return age; }

        }

        public string Gender

        {

            set { gender = value; }

            get { return gender; }

        }

        public int InitialBalnce

        {

            set { initbalance = value; }

            get { return initbalance; }





        }





        class Program

        {

            static void Main(string[] args)

            {

                Console.WriteLine("Encapsulation demo");

                BankAccount b1 = new BankAccount();

                b1.setAge(40);

                b1.setInitialBal(3500);

                b1.setGender("M");

                b1.setpassword("pass");



                Console.WriteLine("Give valid username and password");





                string userName = Console.ReadLine();

                string password = Console.ReadLine();

                Console.WriteLine("Username is: " + userName);



                if (userName == "jahidul" && password == "pass")

                {

                    Console.WriteLine(b1.getAge());

                    Console.WriteLine(b1.getGender());

                    Console.WriteLine(b1.getInitialBal());

                }

                else

                {

                    Console.WriteLine("Invalid User name or password");

                }





            }

        }

    }
}