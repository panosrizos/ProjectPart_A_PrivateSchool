using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PartA
{
    class Trainer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public SelectSubject Subject { get; set; }
        public Course course { get; set; }

        public Trainer()
        {
        }

        public Trainer(string firstName, string lastName, SelectSubject subject)
        {
            FirstName = firstName;
            LastName = lastName;
            Subject = subject;
            
        }

        public string GiveFirstName()
        {

            string firstname;

            Console.Write("\tType the firstName   : ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            firstname = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            while (string.IsNullOrEmpty(firstname) || string.IsNullOrWhiteSpace(firstname) || firstname.Length <= 2)
            {
                Console.Beep();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t!(FirstName needs at least two characters without spaces)");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\tType the firstName   : ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                firstname = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
            }
            return FirstName = firstname;
        }




        public string GiveLastName()
        {
            string lastname;

            Console.Write("\tType the LastName    : ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            lastname = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            while (string.IsNullOrEmpty(lastname) || string.IsNullOrWhiteSpace(lastname) || lastname.Length <= 2)
            {
                Console.Beep();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t!(Lastname needs at least two characters without spaces)");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\tType the LastName    : ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                lastname = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
            }
            return lastname;
        }


        public SelectSubject GiveTrainersSubject() 
        {
            Console.Write("\tGive the Subject : 1. OOP  2. FrontEnd  3.SQL : ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            string choice = Console.ReadLine();
            while (choice != "1" && choice != "2" && choice != "3")
            {
                Console.Beep();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\tWrong Input!Select between the choices : 1. OOP  2. FrontEnd  3.SQL");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\tGive the Subject : 1. OOP  2. FrontEnd  3.SQL : ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                choice = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
            }

            Console.ForegroundColor = ConsoleColor.White;
            switch (choice)
            {
                case "1":
                    Subject = SelectSubject.OOP;
                    break;
                case "2":
                    Subject = SelectSubject.FrontEnd;
                    break;
                case "3":
                    Subject = SelectSubject.SQL;
                    break;
            }

            return Subject;
        }


        public void Initrainer()
        {
            FirstName = GiveFirstName();
            LastName = GiveLastName();
            Subject = GiveTrainersSubject();
                 
        }

        public void PrintTheTrainerEntry()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write($"\n\tEntry completed succesfully : ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"\t{FirstName} {LastName} , {Subject} ");
        }


    }


}
