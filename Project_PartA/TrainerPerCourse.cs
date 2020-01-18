using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PartA
{
    class TrainerPerCourse
    {
        public Course course { get; set; }

        public TrainerPerCourse(Course course, List<Trainer> trainers)
        {
            this.course = course;
            course.Trainers = trainers;
        }

        public void Output()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\t{course.Title} {course.Type}");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var item in course.Trainers)
            {
                Console.WriteLine("\t");
                Console.Write($"\t{item.FirstName,-13} {item.LastName,-15}");
                Console.WriteLine(item.Subject);
            }
            Console.WriteLine();
            Console.WriteLine();
        }

    }
}
