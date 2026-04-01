using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQToObjectsAndQueryOperators
{
    internal class UniversityManager
    {
        public List<University> universities;
        public List<Student> students;

        // constructor
        public UniversityManager()
        {
            universities = new List<University>();
            students = new List<Student>();

            universities.Add(new University { Id=1, Name="Yale" });
            universities.Add(new University { Id=2, Name="Beijing Tech" });

            students.Add(new Student { Id=1, Name="Carla", Gender="female", Age=17, UniversityId=1 });
            students.Add(new Student { Id=2, Name="Toni", Gender="male", Age=21, UniversityId=1 });
            students.Add(new Student { Id=3, Name="Leyla", Gender="female", Age=19, UniversityId=2 });
            students.Add(new Student { Id=4, Name="James", Gender="nonbinary", Age=25, UniversityId=2 });
            students.Add(new Student { Id=5, Name="Linda", Gender="female", Age=22, UniversityId=2 });
        }
        public void MaleStudents()
        {
            IEnumerable<Student> maleStudents = from student in students where student.Gender == "male" select student;
            Console.WriteLine("Male Students: ");
            foreach(Student student in maleStudents)
            {
                student.Print();
            }
        }

        public void FemaleStudents()
        {
            IEnumerable<Student> femaleStudents = from student in students where student.Gender == "female" select student;
            Console.WriteLine("Female Students: ");
            foreach (Student student in femaleStudents)
            {
                student.Print();
            }
        }
    }
}
