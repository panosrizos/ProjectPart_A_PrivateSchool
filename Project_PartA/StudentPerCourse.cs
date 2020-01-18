using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PartA
{
    class StudentPerCourse
    {
        public Course course { get; set; }


        public StudentPerCourse(Course course,List<Student>students)
        {
            this.course = course;
            course.students = students;

            foreach (var item in students)
            {

                item.StudentCourses.Add(course);
            }
        }



        public void Output()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\t{course.Title} {course.Type}");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var item in course.students)
            {
                Console.WriteLine("\t");
                Console.WriteLine($"\t{item.FirstName,-10} {item.LastName,-13}  {item.DateOfBirth.ToShortDateString()}      TuitionFees : {item.TuitionFees} euros");
            }
                Console.WriteLine();
                Console.WriteLine();
        }



        

    }
}
