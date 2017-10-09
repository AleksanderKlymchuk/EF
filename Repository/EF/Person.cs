using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public partial class Student : IStudent
    {
        IEnumerable<IStudentCourse> IStudent.StudentCourse => StudentCourse;
        public void SetProperties(StudentProperties properties)
        {
            FirstName = properties.FirstName ?? FirstName;
            LastName = properties.LastName ?? LastName;
            Age = properties.Age ?? Age;
            if (properties.StudentCourse != null)
            {
                StudentCourse = properties.StudentCourse.Value.Select(x => new StudentCourse() { Course = x.Course }).ToList();
            }
        }

    }
}

