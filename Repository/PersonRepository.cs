using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Linq.Expressions;
using Repository.EF;

namespace Repository
{
    public class StudentRepository : GenericRepository<IStudent,StudentProperties,Student>, IStudentRepository
    {
        public StudentRepository(IMyDbContext context):base (context) 
        {
        
        }
        public override IStudent Get(int Id)
        {
            return _context.Students.Include(x=>x.StudentCourses).FirstOrDefault(i=>i.Id==Id);
        }
        public override void Add(StudentProperties obj)
        {
            var student = new Student();
            student.SetProperties(obj);
            _context.Students.Add(student);
            _context.SaveChanges();
           
        }

        public void Update(int studentId, StudentProperties obj)
        {
            var student = _context.Students.Find(studentId);

            _context.StudentCourses.RemoveRange(student.StudentCourses);
            _context.SaveChanges();
            student.SetProperties(obj);
            _context.SaveChanges();
        }
    }
}
