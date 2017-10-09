using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class StudentService
    {
        IStudentRepository repository;
        public StudentService(IStudentRepository repository)
        {
            this.repository = repository;

        }

        public IStudent Get(int Id)
        {
            return repository.Get(Id);
        }
        public void Remove(IStudent Student)
        {
            repository.Remove(Student);
        }
        public void Add(StudentProperties properties)
        {
            repository.Add(properties);
        }
        public void Update(int studentId ,StudentProperties properties)
        {
            repository.Update(studentId, properties);
        }
    }
}
