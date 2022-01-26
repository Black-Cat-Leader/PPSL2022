// Class: CSE 1321L
//Section: #01 C#
//Term: Spring 2022
//Instructor: Yamini Hanisha Talluri
//Name: Thea Buckler
//Lab#: Lab3B

using System;

namespace Lab3B
{ 

    class Lab3B
    {
        static void Main(string[] args)
        {
            float course1_hours;
            float course1_grade;
            float course1_quality;
            float course2_hours;
            float course2_grade;
            float course2_quality;
            float course3_hours;
            float course3_grade;
            float course3_quality;
            float course4_hours;
            float course4_grade;
            float course4_quality;
            float total_hours;
            float total_quality;
            float GPA;

            Console.Write("Course 1 hours: ");
            course1_hours = Convert.ToSingle(Console.ReadLine());
            Console.Write("Grade for course 1: ");
            course1_grade = Convert.ToSingle(Console.ReadLine());
            course1_quality = course1_hours * course1_grade;

            Console.Write("Course 2 hours: ");
            course2_hours = Convert.ToSingle(Console.ReadLine());
            Console.Write("Grade for course 2: ");
            course2_grade = Convert.ToSingle(Console.ReadLine());
            course2_quality = course2_hours * course2_grade;

            Console.Write("Course 3 hours: ");
            course3_hours = Convert.ToSingle(Console.ReadLine());
            Console.Write("Grade for course 3: ");
            course3_grade = Convert.ToSingle(Console.ReadLine());
            course3_quality = course3_hours * course3_grade;

            Console.Write("Course 4 hours: ");
            course4_hours = Convert.ToSingle(Console.ReadLine());
            Console.Write("Grade for course 4: ");
            course4_grade = Convert.ToSingle(Console.ReadLine());
            course4_quality = course4_hours * course4_grade;

            total_hours = course1_hours + course2_hours + course3_hours + course4_hours;
            total_quality = course1_quality + course2_quality + course3_quality + course4_quality;
            GPA = total_hours / total_quality;

            Console.WriteLine("Total hours is: {0}", total_hours);
            Console.WriteLine("Total quality points is: {0}", total_quality);
            Console.WriteLine("Your GPA for this semester is ", GPA);
            Console.ReadKey();

        }

    }




}
