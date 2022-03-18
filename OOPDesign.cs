using System;
using System.Linq;
using System.Collections.Generic;

namespace CSharpAssignment
{
    public abstract class Person
    {
        private string name;
        private string gender;
        private DateTime birthdate;
        private string address;

        public string Name { get { return name; } set { name = value; } }

        public string Gender { get { return gender; } set { gender = value; } }

        public DateTime Birthdate { get; set; }

        public string Address { get { return address; } private set { address = value; } }

        public abstract decimal calculateSalary();

        public abstract int calculateAge();
    }

    public abstract class Instructor : Person
    {
        private string title;
        private string department;
        private DateTime joindate;

        public string Department { get; set; }
        public string Title { get; set; }
        public DateTime Joindate { get; set; }

        public override decimal calculateSalary()
        {
            //calculate years of experience 
            var today = DateTime.Today;
            var years = today.Year - Joindate.Year;

            //base + bonus
            if (years >= 10)
            {
                return (decimal)((60 * 40.77) * 2);
            }
            else if (years >= 20)
            {
                return (decimal)((60 * 40.77) * 4);
            }

            return (decimal)(60 * 40.77);
        }

        //Calculate Age of the Person
        public override int calculateAge()
        {
            var today = DateTime.Today;
            var age = today.Year - Birthdate.Year;
            if (Birthdate.Date > today.AddYears(-age)) age--;
            return age;
        }

    }//end of instructor

    public abstract class Student : Person
    {
        private string course;
        private char grade;

        public string Course { get; set; }
        public char Grade { get; private set; }

        //Can take multiple courses
        public List<String> addCourse(string s)
        {
            List<String> courses = new List<String>();
            courses.Add(s);
            return courses;
        }

        //Calculate student GPA based on grades for courses
        public abstract double calculateGpa(Char grades);

        public override decimal calculateSalary()
        { 
            return (decimal)(0);
        }

        public override int calculateAge()
        {
            var today = DateTime.Today;
            var age = today.Year - Birthdate.Year;
            if (Birthdate.Date > today.AddYears(-age)) age--;
            return age;
        }
    }// end of student

    public abstract class Course
    {
        private List<String> students;
        public List<String> Students { get; set; }
    }

    public abstract class Department
    {
        private string head;
        private List<String> courses;

        public string Head { get; set; }
        public List<String> Courses { get; set; }

        public abstract DateTime getSchoolYear(DateTime start, DateTime end);
        public abstract decimal getBudget(DateTime year);

    }
}
