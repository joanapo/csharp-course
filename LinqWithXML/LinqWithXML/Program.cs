using System.Xml.Linq;

namespace LinqWithXML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string studentsXML =
                @"<Students>
                    <Student>
                        <Name>Toni</Name>
                        <Age>21</Age>
                        <University>Yale</University>
                        <Major>Economics</Major>
                    </Student>
                    <Student>
                        <Name>Carla</Name>
                        <Age>17</Age>
                        <University>Yale</University>
                        <Major>Medicine</Major>
                    </Student>
                    <Student>
                        <Name>Leyla</Name>
                        <Age>19</Age>
                        <University>Beijing Tech</University>
                        <Major>Engineering</Major>
                    </Student>
                    <Student>
                        <Name>Frank</Name>
                        <Age>26</Age>
                        <University>Beijing Tech</University>
                        <Major>Computer Science</Major>
                    </Student>
                </Students>";

            XDocument studentsXdoc = new XDocument();
            studentsXdoc = XDocument.Parse(studentsXML);

            var students = from student in studentsXdoc.Descendants("Student")
                           select new
                           {
                               Name = student.Element("Name").Value,
                               Age = student.Element("Age").Value,
                               University = student.Element("University").Value,
                               Major = student.Element("Major").Value
                           };
            foreach ( var student in students )
            {
                Console.WriteLine("Student {0} of Age {1} from University {2} studying {3}", student.Name, student.Age, student.University, student.Major);
            }

            var sortedStudents = from student in students
                                 orderby student.Age
                                 select student;

            foreach (var student in sortedStudents)
            {
                Console.WriteLine("Student {0} of Age {1} from University {2} studying {3}", student.Name, student.Age, student.University, student.Major);
            }

            Console.ReadLine();
        }
    }
}
