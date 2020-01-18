using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PartA
{
    class Assignment
    {

        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime SubDateTime { get; set; }
        public double OralMark { get; set; }
        public double TotalMark { get; set; }
        public Course Course { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();

        public Assignment()
        {

        }

        
        public Assignment(string title, string description, DateTime subDateTime, double oralMark, double totalMark)
        {
            Title = title;
            Description = description;
            SubDateTime = subDateTime;
            OralMark = oralMark;
            TotalMark = totalMark;
        }
        public string GiveTitle() 
        {
            Console.Write("\tGive the Title       : ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            string title = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            while (string.IsNullOrEmpty(title) || string.IsNullOrWhiteSpace(title) || title.Length < 5)
            {
                Console.Beep();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t!(title needs at least five characters )");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\tType the Title    : ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                title = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
            }

            return title;
        }

        public string GiveDescription() 
        {
            Console.Write("\tGive the Description : ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            string description = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            while (string.IsNullOrEmpty(description) || string.IsNullOrWhiteSpace(description) || description.Length < 5)
            {
                Console.Beep();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t!(Description needs at least five characters )");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\tGive the Description : ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                description = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
            }

            return description;
        }
        public double GiveOralMark() 
        {
            double oralMark ;
            Console.Write("\tGive the OralMark    : ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            while (!double.TryParse(Console.ReadLine(),out oralMark) || oralMark < 0)
            {
                Console.Beep();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\tOralMark must be a positive number input!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\tGive the OralMark : ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
            Console.ForegroundColor = ConsoleColor.White;
            return oralMark;

        }

        public double GiveTotalMark()
        {
            double total;
            Console.Write("\tGive the TotalMark   : ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            while (!double.TryParse(Console.ReadLine(), out total) || total < 0)
            {
                Console.Beep();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\tOralMark must be a positive number input!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\tGive the TotalMark    : ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
            Console.ForegroundColor = ConsoleColor.White;
            return total;
        }

        public DateTime GiveSubDate() 
        {
            DateTime paradosh = new DateTime();

            Console.Write("\tGive the SubDate     : ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            while (!DateTime.TryParse(Console.ReadLine(), out paradosh) ||!(paradosh > DateTime.UtcNow ))
            {
                Console.Beep();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\tWrong Input Or Passed Date! ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\tGive the SubDate   : ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
            Console.ForegroundColor = ConsoleColor.White;
            return paradosh;

        }


        public void InitializeAssignment() 
        {
            Title = GiveTitle();
            Description = GiveDescription();
            SubDateTime = GiveSubDate();
            OralMark = GiveOralMark();
            TotalMark = GiveTotalMark();
           
        }

        public void PrintTheAssignmentEntry()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write($"\n\tEntry completed succesfully : ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"\t{Title} {Description} , {SubDateTime.ToShortDateString(),-11} OralMark : {OralMark} TotalMark : {TotalMark}");
        }

        public void PrintTheAssignmentOutput()
        {
            Console.WriteLine($"\t{Title,-11} {Description,-6} {SubDateTime.ToShortDateString(),-13} OralMark : {OralMark} TotalMark : {TotalMark}");
            Console.WriteLine();

        }
    }
}
