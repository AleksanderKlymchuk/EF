using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Linq.Expressions;

namespace Repository
{
    public class StudentRepository : GenericRepository<IStudent,StudentProperties,Student>, IStudentRepository
    {
        public StudentRepository(EFTestEntities context):base (context) 
        {
        
        }
        public override void Add(StudentProperties obj)
        {
            var student = new Student();
            student.SetProperties(obj);
            _context.Student.Add(student);
            _context.SaveChanges();
           
        }

        public void Update(int studentId, StudentProperties obj)
        {
            var student = _context.Student.Find(studentId);

            _context.StudentCourse.RemoveRange(student.StudentCourse);
            _context.SaveChanges();
            student.SetProperties(obj);
            _context.SaveChanges();
        }
    }
}
