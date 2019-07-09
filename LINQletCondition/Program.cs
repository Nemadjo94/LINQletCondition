using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQletCondition
{
    //This C# program is used to implement let condition using LINQ. Create a student class with Name, Regno, Marks variables. 
    //    The program class is used for object initialization for student class. The let clause allows storing the result of an
    //    expression inside the query expression.
    //    The where clause is used in a query expression to specify which elements from the data source will be returned in the 
    //    query expression.The foreach() function is used to print only the average marks greater than student marks.
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student{ Name="Tom", Id="R001", Mark=80},
                new Student{ Name="Bob", Id="R002", Mark=40},
                new Student{ Name="Jerry", Id="R003", Mark=25},
                new Student{ Name="Syed", Id="R004", Mark=30},
                new Student{ Name="Mob", Id="R005", Mark=70},
                new Student{ Name="Nemanja", Id="R006", Mark=99}
            };
            //Get the students whose Marks are higher than the classes average

            
            var result = from student in students
                         let totalMarks = students.Sum(mark => mark.Mark)
                         let avgMarks = totalMarks / students.Count
                         where avgMarks < student.Mark
                         select student;
            foreach(var student in result)
            {
                Console.WriteLine($"Student: {student.Name} {student.Id}");
            }
        }
    }
}
