using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Project_PartA
{
    class DataBase
    {
        public List<Student> Students { get; set; }
        public List<Trainer> Trainers { get; set; }
        public List<Assignment> Assignments { get; set; }
        public List<Course> Courses { get; set; }
        public List<StudentPerCourse> StudentPerCourses { get; set; }
        public List<TrainerPerCourse> trainerPerCourses { get; set; }
        public List<AssignmentsPerCourse> assignmentPerCourse { get; set; }




        public DataBase()
        {
            Student s1 = new Student("Panos", "Rizos", new DateTime(1993, 04, 12), 300);
            Student s2 = new Student("Nikos", "Ioannou", new DateTime(1992, 05, 13), 1.555);
            Student s3 = new Student("Kostas", "Dimitriou", new DateTime(1991, 06, 14), 500);
            Student s4 = new Student("Giannis", "Arvanitis", new DateTime(1990, 07, 15), 600);
            Student s5 = new Student("Maria", "Apostolou", new DateTime(1990, 08, 16), 800);
            Student s6 = new Student("Panos", "Mixahl", new DateTime(1989, 09, 17), 900);
            Student s7 = new Student("Eleni", "Theodwrou", new DateTime(1979, 01, 18), 1.125);
            Student s8 = new Student("Kostas", "Papadopoulos", new DateTime(1996, 02, 20), 400);
            Student s9 = new Student("Mixalis", "Petrou", new DateTime(1993, 05, 21), 100);
            Student s10 = new Student("Petros", "Karagiannis", new DateTime(1991, 12, 03), 200);
            Student s11 = new Student("Nikos", "Gianou", new DateTime(1991, 12, 03), 200);
            Student s12 = new Student("Kostas", "Mixahl", new DateTime(1991, 12, 03), 200);
            Student s13 = new Student("Iosif", "Papapetrou", new DateTime(1991, 12, 03), 200);
            Student s14 = new Student("Pelopidas", "Euaggeliou", new DateTime(1991, 12, 03), 1.265);
            Student s15 = new Student("Eirini", "Kostopoulou", new DateTime(1991, 12, 03), 200);
            Student s16 = new Student("Danah", "Goranith", new DateTime(1991, 12, 03), 200);


            Students = new List<Student>() { s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12, s13, s14, s15, s16 };




            Course c1 = new Course("CB8", "C#", "FullTime", new DateTime(2019, 01, 01), new DateTime(2019, 03, 31));
            Course c2 = new Course("CB8", "C++", "PartTime", new DateTime(2019, 01, 01), new DateTime(2019, 06, 29));
            Course c3 = new Course("CB9", "JAVA", "FullTime", new DateTime(2019, 03, 01), new DateTime(2019, 06, 30));
            Course c4 = new Course("CB9", "PHP", "PartTime", new DateTime(2019, 03, 01), new DateTime(2019, 09, 28));


            Courses = new List<Course>() { c1, c2, c3, c4 };



            Assignment as1 = new Assignment("Individual", "PartA", new DateTime(2020, 01, 10), 30, 70);
            Assignment as2 = new Assignment("Begginers", "PartA", new DateTime(2020, 01, 20), 30, 70);
            Assignment as3 = new Assignment("Bootcamp", "PartB", new DateTime(2020, 02, 14), 40, 60);
            Assignment as4 = new Assignment("Individual", "PartB", new DateTime(2020, 02, 27), 40, 60);
            Assignment as5 = new Assignment("Bootcamp", "PartA", new DateTime(2020, 01, 29), 40, 60);
            Assignment as6 = new Assignment("Finall", "Full", new DateTime(2020, 03, 19), 50, 50);
            Assignment as7 = new Assignment("Individual", "Full", new DateTime(2020, 03, 17), 50, 50);
            Assignment as8 = new Assignment("Begginers", "PartB", new DateTime(2020, 02, 10), 50, 50);
            Assignment as9 = new Assignment("Team", "Full", new DateTime(2020, 03, 18), 50, 50);
            Assignment as10 = new Assignment("Begginers", "PartA", new DateTime(2020, 02, 12), 50, 50);
            Assignment as11 = new Assignment("Team", "Full", new DateTime(2020, 02, 17), 50, 50);
            Assignment as12 = new Assignment("Individual", "PartB", new DateTime(2020, 02, 03), 50, 50);

            Assignments = new List<Assignment>() { as1, as2, as3, as4, as5,as6,as7,as8,as9,as10,as11,as12 };


            Trainer t1 = new Trainer("Ektoras", "Gkatzos", SelectSubject.OOP);
            Trainer t2 = new Trainer("Mixalis", "Gianou", SelectSubject.FrontEnd);
            Trainer t3 = new Trainer("Kostantinos", "Zitis", SelectSubject.FrontEnd);
            Trainer t4 = new Trainer("Gewrgios", "Pasparakis", SelectSubject.SQL);
            Trainer t5 = new Trainer("Nikos", "Pavlou", SelectSubject.OOP);

            Trainers = new List<Trainer>() { t1, t2, t3, t4, t5 };




            List<Trainer> c1trainers = new List<Trainer>() { t1, t2, t4 };
            List<Trainer> c2trainers = new List<Trainer>() { t2, t4, t5 };
            List<Trainer> c3trainers = new List<Trainer>() { t3, t4, t5 };
            List<Trainer> c4trainers = new List<Trainer>() { t1, t3, t4 };



            TrainerPerCourse TPC1 = new TrainerPerCourse(c1, c1trainers);
            TrainerPerCourse TPC2 = new TrainerPerCourse(c2, c2trainers);
            TrainerPerCourse TPC3 = new TrainerPerCourse(c3, c3trainers);
            TrainerPerCourse TPC4 = new TrainerPerCourse(c4, c4trainers);


            trainerPerCourses = new List<TrainerPerCourse>() { TPC1, TPC2, TPC3, TPC4 };



            List<Student> c1Students = new List<Student>() { s1, s2, s3, s4, s5, s6 };
            List<Student> c2Students = new List<Student>() { s6, s7, s8, s9, s10, s3 };
            List<Student> c3Students = new List<Student>() { s11, s12, s13, s14, s4, s5 };
            List<Student> c4Students = new List<Student>() { s15, s16, s1, s2, s14 };


            StudentPerCourse SPC1 = new StudentPerCourse(c1, c1Students);
            StudentPerCourse SPC2 = new StudentPerCourse(c2, c2Students);
            StudentPerCourse SPC3 = new StudentPerCourse(c3, c3Students);
            StudentPerCourse SPC4 = new StudentPerCourse(c4, c4Students);

            StudentPerCourses = new List<StudentPerCourse>() { SPC1, SPC2, SPC3, SPC4 };




            List<Assignment> c1assignments = new List<Assignment>() { as1, as3, as4};
            List<Assignment> c2assignments = new List<Assignment>() { as5, as6, as7 };
            List<Assignment> c3assignments = new List<Assignment>() { as8, as9, as10 };
            List<Assignment> c4assignments = new List<Assignment>() { as11,as12  };

            AssignmentsPerCourse ASPC1 = new AssignmentsPerCourse(c1, c1assignments);
            AssignmentsPerCourse ASPC2 = new AssignmentsPerCourse(c2, c2assignments);
            AssignmentsPerCourse ASPC3 = new AssignmentsPerCourse(c3, c3assignments);
            AssignmentsPerCourse ASPC4 = new AssignmentsPerCourse(c4, c4assignments);

            assignmentPerCourse = new List<AssignmentsPerCourse>() { ASPC1, ASPC2, ASPC3, ASPC4 };

        }



        public string StringAnswer() 
        {
            string choice = string.Empty;

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            choice = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;

            return choice;
        }



        public void GotoAssignDaySub()
        {
            string input = string.Empty;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\n\tASSIGNNMENTS SUBMITION\n\n");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("\tPess 1. To check for Assignments Submition\n ");
            Console.Write("\tPess 2. To Return to");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" Main Menu\n ");
            while (!(input == "1" || input == "2")) 
            {
            Console.Write("\tChoice : ");
            input = StringAnswer();
            }
            switch (input)
            {
                case "1":
                    CheckAssignmentsDate();
                    break;
                case "2":
                    GobackStartmenu();
                    break;
                default:
                    Console.Write("\tChoice : ");
                    input = StringAnswer();
                    break;
            }
        }




        public void CheckAssignmentsDate()
        {
            DateTime date = new DateTime();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\n\n\tGive the date you want to check for Assignments Submition  : ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            while (!DateTime.TryParse(Console.ReadLine(), out date)) 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t Wrong input!Please try again! ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("\n\tGive the date you want to check for Assignments Submition  : ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
            Console.ForegroundColor = ConsoleColor.White;

                 if (date.DayOfWeek == DayOfWeek.Tuesday)  { date.AddDays(-1); }
            else if (date.DayOfWeek == DayOfWeek.Wednesday){ date.AddDays(-2); }
            else if (date.DayOfWeek == DayOfWeek.Thursday) { date.AddDays(-3); }
            else if (date.DayOfWeek == DayOfWeek.Friday)   { date.AddDays(-4); }
            else if (date.DayOfWeek == DayOfWeek.Saturday) { date.AddDays(-5); }
            else if (date.DayOfWeek == DayOfWeek.Sunday)   { date.AddDays(-6); }

            foreach (var student in Students)
            {
                foreach (var assignment in student.StudentAssignments)
                {
                    if (assignment.SubDateTime >= date && assignment.SubDateTime <= date.AddDays(4))
                    {
                        student.StudentOutput();
                        assignment.PrintTheAssignmentOutput();
                    }
                }
            }
            GotoAssignDaySub();
        }




        public void PrintStudentWithMoreCourses()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\tSTUDENTS WITH TWO OR MORE COURSES : ");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var item in Students)
            {
                if (item.StudentCourses.Count > 1) item.PrintStudentCourses();
            }
        }




        public void PrintStudentsCourseAssignment()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\tALL THE ASSIGNMENTS OF STUDENTS PER COURSE");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var student in Students)
            {
                student.StudentOutput();
                Console.WriteLine();
                foreach (var course in student.StudentCourses)
                {
                    course.PrintTheCourseOutput();
                    Console.WriteLine();
                    foreach (var assignment in course.Assignments)
                    {
                        assignment.PrintTheAssignmentOutput();
                    }
                }
            }

            Console.WriteLine();
        }



        public void PrintStudentsPerCourse()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\tALL THE STUDENTS OF SCHOOL PER COURSE : \n\n");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var item in StudentPerCourses)
            {
                item.Output();
            }
            Console.WriteLine();
        }



        public void PrintTrainersPerCourse()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\tALL THE TRAINERS OF SCHOOL PER COURSE : \n\n");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var item in trainerPerCourses)
            {
                item.Output();
            }
            Console.WriteLine();
        }



        public void PrintAssignmentsPerCourse()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\tALL THE ASSAIGNMENTS OF SCHOOL PER COURSE : \n\n");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var item in assignmentPerCourse)
            {
                item.Output();
            }
            Console.WriteLine();
        }



        public void PrintAllTrainersInList()

        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\tALL THE TRAINERS OF SCHOOL : \n\n");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var item in Trainers)
            {
                Console.WriteLine($"\t{item.FirstName,-12} {item.LastName,-12}  {item.Subject}");
                Console.WriteLine();
            }

            Console.WriteLine();
        }




        public void PrintAllAssignmentsInList()

        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\tALL THE ASSAIGNMENTS OF SCHOOL : \n\n");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var item in Assignments)
            {
                Console.WriteLine($"\t{item.Title,-17} {item.Description,-8} {item.SubDateTime.ToShortDateString(),-13}  OralMark : {item.OralMark}  TotalMark : {item.TotalMark}");
                Console.WriteLine();
            }
            Console.WriteLine();
        }



        public void PrintAllStudentsInList()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\tALL THE STUDENTS OF SCHOOL : \n\n");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var item in Students)
            {
                Console.WriteLine($"\t{item.FirstName,-15} {item.LastName,-12}  {item.DateOfBirth.ToShortDateString(),-13} Tuitions : {item.TuitionFees,-7}");
                Console.WriteLine();
            }
            Console.WriteLine();
        }


        public void PrintAllCoursesInList()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\tALL THE COURSES OF THE SCHOOL : \n\n");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var item in Courses)
            {
                Console.WriteLine($"\t{item.Title,-5} {item.Stream,-6}  {item.Type,-8}   {item.StartDate.ToShortDateString()} - {item.EndDate.ToShortDateString()}");
                Console.WriteLine();
            }
            Console.WriteLine();
        }


        public void PrintAllData() 
        {
            PrintAllStudentsInList();
            PrintAllTrainersInList();
            PrintAllAssignmentsInList();
            PrintAllCoursesInList();
            PrintStudentsPerCourse();
            PrintTrainersPerCourse();
            PrintAssignmentsPerCourse();
            PrintStudentsCourseAssignment();
            PrintStudentWithMoreCourses();
        }

        // layout 

        public static void Welcome()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\n\tRIZOS PRIVATE SCHOOL SYSTEM   ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(DateTime.Now);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n");

        }

        
        public string CheckContinueOrNot() 
        {
            string answer = string.Empty;

            Console.WriteLine("\n\tPress C to Continue Adding : ");
            Console.WriteLine("\tPress B to go Back to Menu : ");
            Console.Write("\t                           : ");
            answer = StringAnswer();
            while (!(answer.ToUpper() == "B" || answer.ToUpper() == "C"))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\tChoose Between C Or B");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\t                           : ");
                answer = StringAnswer();

            }

            return answer;

        }

        public void ContinueAddingCourseOrNot()
        {
            string answer = CheckContinueOrNot();
                        
            while (answer.ToUpper() == "C")
            {
                Console.Clear();
                Welcome();
                Course c = new Course();
                c.InitializeCourse();
                Courses.Add(c);
                c.PrintTheCourseEntry();
                Console.WriteLine("\n\tPress C to Continue Adding : ");
                Console.WriteLine("\tPress B to go Back to Menu : ");
                Console.Write("\t                           : ");
                answer = StringAnswer();
            }
            if (answer.ToUpper() == "B")
            {
                Console.Clear();
                Welcome();
                InsertMenu();
            }

        }

        public void ContinueAddingTrainerOrNot()
        {
            string answer = CheckContinueOrNot();

            while (answer.ToUpper() == "C")
            {
                Console.Clear();
                Welcome();
                Trainer t = new Trainer();
                t.Initrainer();
                Trainers.Add(t);
                t.PrintTheTrainerEntry();
                Console.WriteLine("\n\tPress C to Continue Adding : ");
                Console.WriteLine("\tPress B to go Back to Menu : ");
                Console.Write("\t                           : ");
                answer = StringAnswer();
            }
            if (answer.ToUpper() == "B")
            {
                Console.Clear();
                Welcome();
                InsertMenu();
            }

        }

        public void ContinueAddingAsOrNot()
        {

            string answer = CheckContinueOrNot();
                       
            while (answer.ToUpper() == "C")
            {
                Console.Clear();
                Welcome();
                Assignment a = new Assignment();
                a.InitializeAssignment();
                Assignments.Add(a);
                a.PrintTheAssignmentEntry();
                Console.WriteLine("\n\tPress C to Continue Adding : ");
                Console.WriteLine("\tPress B to go Back to Menu : ");
                Console.Write("\t                           : ");
                answer = StringAnswer();
            }
            if (answer.ToUpper() == "B")
            {
                Console.Clear();
                Welcome();
                InsertMenu();
            }

        }

        public void ContinueAddingStudOrNot()
        {
            string answer = CheckContinueOrNot();

            while (answer.ToUpper() == "C")
            {
                Console.Clear();
                Welcome();
                Student s = new Student();
                s.InitStudent();
                Students.Add(s);
                s.PrintTheStudentEntry();
                Console.WriteLine("\n\tPress C to Continue Adding : ");
                Console.WriteLine("\tPress B to go Back to Menu : ");
                Console.Write("\t                           : ");
                answer = StringAnswer();
            }
            if (answer.ToUpper() == "B")
            {
                Console.Clear();
                Welcome();
                InsertMenu();
            }

        }



        public void GobackStartmenu()
        {
            Console.Clear();
            Welcome();
            IntroInitialOrSynthetic();
        }

        public void LogOut()
        {
            Console.Clear();
            Welcome();
            Console.WriteLine("\tYou selected LogOut");
            Thread.Sleep(2000);
            Console.Clear();
        }


        // InitializeOrNot-Start Menu

        public void IntroInitialOrSynthetic()
        {
            string choice = string.Empty;
            Console.WriteLine("\t1.You can Insert Data.\n");
            Console.WriteLine("\t2.You can use Synthetic Data.\n");
            Console.Write("\t0. ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("LogOut\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\n\tChoose ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("1,2 or 0 : ");
            choice = StringAnswer();
            while (!(choice == "1" || choice == "2" || choice == "0"))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t!Choose Between (1,2,0)");
                Console.Beep();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("\n\tChoose ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("1,2 or 0 : ");
                choice = StringAnswer();
                Console.ForegroundColor = ConsoleColor.White;
            }

            if (choice == "1")
            {
                Console.Clear();
                Welcome();
                InsertMenu();

            }
            else if (choice == "2")
            {
                Console.Clear();
                Welcome();
                SyntheticMenu();
            }
            else if (choice == "0") 
            {
                LogOut();
            }
        }


        // Menu Insert Data

        public void InsertMenu() 
        {
            string answer = string.Empty;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\tMENU\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\t1. Add new Course\n");
            Console.WriteLine("\t2. Add new Trainer\n");
            Console.WriteLine("\t3. Add new Assignment\n");
            Console.WriteLine("\t4. Add new Student\n");
            Console.Write("\t5. ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Return to Main Menu\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\t0. ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("LogOut\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\tChoice : ");
            answer = StringAnswer();
            while (!(answer == "1" || answer == "2" || answer == "3"|| answer == "4" || answer == "5" || answer == "0"))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\tChoose Between (1,2,3,4,5,0)");
                Console.Beep();
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\tChoice : ");
                answer = StringAnswer();
            }
            switch (answer)
            {
                case "1":
                    Console.Clear();
                    Welcome();
                    Course c = new Course();
                    c.InitializeCourse();
                    Courses.Add(c);
                    c.PrintTheCourseEntry();
                    ContinueAddingCourseOrNot();
                    break;
                case "2":
                    Console.Clear();
                    Welcome();
                    Trainer t = new Trainer();
                    t.Initrainer();
                    Trainers.Add(t);
                    t.PrintTheTrainerEntry();
                    ContinueAddingTrainerOrNot();
                    break;
                case "3":
                    Console.Clear();
                    Welcome();
                    Assignment a = new Assignment();
                    a.InitializeAssignment();
                    Assignments.Add(a);
                    a.PrintTheAssignmentEntry();
                    ContinueAddingAsOrNot();
                    break;
                case "4":
                    Console.Clear();
                    Welcome();
                    Student s = new Student();
                    s.InitStudent();
                    Students.Add(s);
                    s.PrintTheStudentEntry();
                    ContinueAddingStudOrNot();
                    break;
                case "5":
                    GobackStartmenu();
                    break;
                case "0":
                    LogOut();
                    break;
            }


        }

        // Syntetic menu
        public void SyntheticMenu()
        {
            string answer = string.Empty;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\tMENU\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\t1. Print All Synthetic Data\n");
            Console.WriteLine("\t2. Go Back to Start Menu\n");
            Console.Write("\t0. ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("LogOut\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\tChoice : ");
            answer = StringAnswer();
            while (!(answer == "1" || answer == "2" || answer == "0")) 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\tChoose Between (1,2,0)");
                Console.Beep();
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\tChoice : ");
                answer = StringAnswer();

            }

            switch (answer) 
            {
                case "1":
                    Console.Clear();
                    Welcome();
                    PrintAllData();
                    GotoAssignDaySub();
                    break;
                case "2":
                    Console.Clear();
                    Welcome();
                    GobackStartmenu();
                    break;
                case "0":
                    Console.Clear();
                    Welcome();
                    LogOut();
                    break;
            }

        }


        // Method runs the programm
        public void Run()
        {

            Welcome();
            IntroInitialOrSynthetic();

        }



    }
}
