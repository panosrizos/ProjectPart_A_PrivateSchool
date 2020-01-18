using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PartA
{
    class Student
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public double TuitionFees { get; set; }
        public List<Course> StudentCourses { get; set; } = new List<Course>();
        public List<Assignment> StudentAssignments { get; set; } = new List<Assignment>();


        public Student()
        {

        }



        public Student(string firstName, string lastName, DateTime dateOfBirth, double tuitionFees)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            TuitionFees = tuitionFees;
        }
        public string GiveFirstName()
        {

            string firstname;

            Console.Write("\tType the firstName   : ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            firstname = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            while (string.IsNullOrEmpty(firstname) || string.IsNullOrWhiteSpace(firstname) || firstname.Length < 2)
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
            string  lastname;

            Console.Write("\tType the LastName    : ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            lastname = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            while (string.IsNullOrEmpty(lastname) || string.IsNullOrWhiteSpace(lastname) || lastname.Length < 2)
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



        public DateTime GiveBirthDate() 
        {
            DateTime birth = new DateTime();
            DateTime from = new DateTime(1940,01,01);
            DateTime until = new DateTime(2010,01,01);

            Console.Write("\tGive the BirthDate   : ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            while (!DateTime.TryParse(Console.ReadLine(), out birth) || !(birth > from && birth < until)) 
            {
                Console.Beep();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\tWrong Input!Give a valid BirthDate! ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\tGive the BirthDate   : ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
            Console.ForegroundColor = ConsoleColor.White;
            return birth;
        }

        public double GiveTuitionFees() 
        {
            double fees;
            Console.Write("\tGive the TuitionFees : ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            while (!double.TryParse(Console.ReadLine(), out fees)|| fees < 0)
            {
                Console.Beep();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\tFess must be positive number input!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\tGive the TuitionFees : ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
                Console.ForegroundColor = ConsoleColor.White;
                return fees;
        }

        public void InitStudent()
        {
            FirstName = GiveFirstName();
            LastName = GiveLastName();
            DateOfBirth = GiveBirthDate();
            TuitionFees = GiveTuitionFees();
        }


        public void PrintStudentCourses()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\n\n\t{FirstName} {LastName} : \n");
            Console.ForegroundColor = ConsoleColor.White;

            foreach (var item in StudentCourses)
            {
                Console.WriteLine($"\t{item.Title,-5} {item.Stream,-6} {item.Type}    {item.StartDate.ToShortDateString()} / {item.EndDate.ToShortDateString()} ");
                Console.WriteLine();

            }
        }


        public void PrintStudentAssignments()
        {
            
            foreach (var item in StudentAssignments)
            {
                Console.WriteLine($"\t{item.Title} {item.Description} , {item.SubDateTime.ToShortDateString(),-11} OralMark : {item.OralMark} TotalMark : {item.TotalMark}");

            }
        }

        public void PrintTheStudentEntry()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write($"\n\tEntry completed succesfully : ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"\t{FirstName} {LastName} , {DateOfBirth.ToShortDateString()} Tuitions : {TuitionFees}");
        }

        public void StudentOutput()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\t{FirstName} {LastName} :");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }

    }
}
