using Model;
using Repository;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new EFTestEntities();
            using (var rep = new StudentRepository(context)) {
                var ser = new StudentService(rep);
                var proper = new StudentProperties()
                {
                    //FirstName = "Oleksandr",
                    //LastName = "Klymchuk",
                    //Age = 31,
                    StudentCourse=new List<StudentCourseProperties>() {
                        new StudentCourseProperties() { Course =4},
                        //new StudentCourseProperties() { Course=2}
                    }

                };

                ser.Update(2,proper);
            }            
        }
    }
}
