using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Project_PartA
{
    class AssignmentsPerCourse
    {
        public Course Course { get; set; }
        public AssignmentsPerCourse(Course course, List<Assignment> assignments)
        {
            this.Course = course;
            course.Assignments = assignments;
            foreach (var item in assignments)
            {
                item.Course = course;
            }

            foreach (var item in course.Assignments)
            {
                
                foreach (var it in course.students)
                {
                 it.StudentAssignments.Add(item);
                }
            }
        }



        public void Output()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\t{Course.Title} {Course.Type} {Course.Stream}");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var item in Course.Assignments)
            {
                Console.WriteLine("\t");
                Console.WriteLine($"\t{item.Title,-12} {item.Description,-7}  SubDateTime: {item.SubDateTime.ToShortDateString(),-10}  OralMark : {item.OralMark}  /  TotalMark : {item.TotalMark}");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
