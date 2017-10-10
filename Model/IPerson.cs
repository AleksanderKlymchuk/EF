using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public interface IStudent
    {
        int Id { get; }
        string FirstName { get; }
        string LastName { get; }
        int Age { get; }
        string Addres { get; }
        IEnumerable<IStudentCourse> StudentCourse { get; }
        void SetProperties(StudentProperties properties);
    }
    public interface IStudentCourse
    {
        int Id { get; }
        int StudentId { get; }
        int Course { get; }
    }
}
