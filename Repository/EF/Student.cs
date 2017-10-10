using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.EF
{
    public partial class Student : IStudent
    {
        IEnumerable<IStudentCourse> IStudent.StudentCourse => StudentCourses;
        public void SetProperties(StudentProperties properties)
        {
            FirstName = properties.FirstName ?? FirstName;
            LastName = properties.LastName ?? LastName;
            Age = properties.Age ?? Age;
            if (properties.StudentCourse != null)
            {
                StudentCourses = properties.StudentCourse.Value.Select(x => new StudentCourse() { Course = x.Course }).ToList();
            }
        }

    }
}

