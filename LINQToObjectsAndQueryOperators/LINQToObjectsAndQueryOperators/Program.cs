using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQToObjectsAndQueryOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UniversityManager um = new UniversityManager();

            um.MaleStudents();
            um.FemaleStudents();
            um.SortStudentsByAge();
            um.AllStudentsFromBeijingTech();
            um.StudentAndUniversityNameCollection();

            Console.Write("Input the university ID: ");
            string input = Console.ReadLine();
            try
            {
                int inputAsInt = Convert.ToInt32(input);

                um.AllStudentsFromSpecificUni(inputAsInt);
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong value");
            }

            Console.ReadLine();
        }
    }
}
