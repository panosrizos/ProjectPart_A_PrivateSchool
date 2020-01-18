using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PartA
{
    class Course
    {

        public string Title { get; set; }
        public string Stream { get; set; }
        public string Type { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public List<Trainer> Trainers { get; set; } = new List<Trainer>();
        public List<Student> students { get; set; } = new List<Student>();
        public List<Assignment> Assignments { get; set; } = new List<Assignment>();


        public Course()
        {
           
        }

        public Course(string title, string stream, string type, DateTime startDate, DateTime endDate)
        {
            Title = title;
            Stream = stream;
            Type = type;
            StartDate = startDate;
            EndDate = endDate;
        }

        public string GiveTitle()
        {
            Console.Write("\tGive the Title       : ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            string title = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            while (string.IsNullOrEmpty(title) || string.IsNullOrWhiteSpace(title) || title.Length <=2)
            {
                Console.Beep();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t!(title needs at least two characters)");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\tGive the Title       : ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                title = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
            }

            return title;
        }

        public string GiveStream() 
        {
            string stream;

            Console.Write("\tGive the Stream      : ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            stream = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            while (string.IsNullOrEmpty(stream) || string.IsNullOrWhiteSpace(stream))
            {
                Console.Beep();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t!(Wrong-empty Input.)");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\tGive the Stream      : ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                stream = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
            }

            return stream;
                                  
        }
        public string GiveType()
        {
            string type;

            Console.Write("\tGive the Type        : ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            type = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            while (string.IsNullOrEmpty(type) || string.IsNullOrWhiteSpace(type))
            {
                Console.Beep();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t!(Wrong-empty Input.)");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\tGive the Type        : ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                type = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
            }

            return type;

        }

        public DateTime GiveStartDate()
        {
            DateTime date= new DateTime();

            Console.Write("\tGive the StartDate   : ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            while (!DateTime.TryParse(Console.ReadLine(),out date ) || date<= DateTime.UtcNow )
            {
                Console.Beep();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\tWrong Input or Passed Date! ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\tGive the StartDate   : ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
            Console.ForegroundColor = ConsoleColor.White;
            return date ;

        }

        public DateTime GiveEndDate()
        {
            DateTime date = new DateTime();

            Console.Write("\tGive the EndDate     : ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            while (!DateTime.TryParse(Console.ReadLine(), out date) ||(date < StartDate))
            {
                Console.Beep();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\tWrong Input or earlier than StartDate ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\tGive the EndDate     : ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
            Console.ForegroundColor = ConsoleColor.White;
            return date;

        }

        public void InitializeCourse()
        {

            Title = GiveTitle();
            Stream = GiveStream();
            Type =GiveType();
            StartDate = GiveStartDate();
            EndDate = GiveEndDate();
            
        }
        

        public void PrintTheCourseEntry()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write($"\n\tEntry completed succesfully : ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"\t{Title} {Stream} ,{Type}, {StartDate.ToShortDateString()} - {StartDate.ToShortDateString()}");
        }

        public void PrintTheCourseOutput()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\t{Title} {Stream}  {Type}");
            Console.ForegroundColor = ConsoleColor.White;

        }

    }



}
